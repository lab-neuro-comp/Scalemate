using System;
using System.IO;
using System.Windows.Forms;
using Scalemate;
using ScalemateForms.Model;
using ScalemateForms.View.Util;
using System.Linq;

namespace ScalemateForms.View
{
    public partial class FormMain : Form, IParent
    {
        public string[] Tests { get; private set; }
        public DataAccessLayer DAL { get; set; }
        public PreferenceManager Prefs { get; set; }
        public TranslationManager Translator { get; set; }

        public FormMain()
        {
            int i;

            DAL = new DataAccessLayer();
            Prefs = new PreferenceManager();
            Translator = new TranslationManager(Prefs.GetLanguage());
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            var lines = Tester.LoadKinds(DAL);
            if (lines.Length > 0)
            {
                Tests = new string[lines.Length];
                i = 0;

                foreach (var line in lines)
                {
                    var stuff = line.Split('\t');
                    Tests[i++] = stuff[0];
                    listKind.Items.Add(stuff[1]);
                }

                listKind.SetSelected(0, true);
            }
            else
            {
                listKind.Items.Add("Não há arquivos de configuração disponíveis.");
            }

            Translate();
        }

        /// <summary>
        /// Begins the test as selected by the user. Before this, the application will 
        /// check for the presence of the survey and the instructions commands.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            Tester mate = new Tester(DAL, Tests[listKind.SelectedIndex], textPatient.Text);
            FormInventory form = new FormInventory(this, mate);

            // Conduct survey
            bool ok = await form.CollectInformation();
            if (!ok)
            {
                form.Close();
                return;
            }

            // Instructing 
            ok = await form.Instruct();
            if (!ok)
            {
                form.Close();
                return;
            }

            form.Start();
        }

        #region UI side effects

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPreferences form = new FormPreferences(this);
            form.Show();
            this.Hide();
        }

        private void docsStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocs form = new FormDocs();
            form.Show();
        }

        private void Translate()
        {
            this.buttonStart.Text = Translator.Get("Start");
            this.textPatient.Text = Translator.Get("Name");
            this.fileToolStripMenuItem.Text = Translator.Get("File");
            this.quitToolStripMenuItem.Text = Translator.Get("Quit");
            this.editToolStripMenuItem.Text = Translator.Get("Edit");
            this.preferencesToolStripMenuItem.Text = Translator.Get("Preferences");
            this.helpStripMenuItem.Text = Translator.Get("Help");
            this.docsStripMenuItem.Text = Translator.Get("Docs");
        }


        #endregion

        #region IParent implementation
        public string Get(string tag)
        {
            return Translator.Get(tag);
        }

        public string Set(string code)
        {
            Translator.SetPreferredLanguage(code);
            return code;
        }

        public string[] GetLanguages()
        {
            // XXX Maybe this should be on the translator? The designer can't know about this, right?
            return GetCodes().Select(code => Translator.Translations[code]["LONG_ID"]).ToArray();
        }

        public string[] GetCodes()
        {
            return Translator.Translations.Keys.ToArray();
        }

        public void Store()
        {
            Prefs.Preferences["Language"] = Translator.Code;
            Prefs.Store();
            Translate();
        }
        #endregion
    }
}
