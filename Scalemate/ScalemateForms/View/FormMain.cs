using System;
using System.IO;
using System.Windows.Forms;
using Scalemate;
using ScalemateForms.Model;

namespace ScalemateForms.View
{
    public partial class FormMain : Form
    {
        public string[] Tests { get; private set; }
        public DataAccessLayer DAL { get; set; }

        public FormMain()
        {
            int i;

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DAL = new DataAccessLayer();

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
            } else
            {
                listKind.Items.Add("Não há arquivos de configuração disponíveis.");
            }
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
            FormInventory form = new FormInventory(mate);
            form.Mother = this;

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
    }
}
