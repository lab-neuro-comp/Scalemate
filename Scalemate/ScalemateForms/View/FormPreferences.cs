using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalemateForms.View
{
    public partial class FormPreferences : Form
    {
        private IParent Mother { get; set; }

        public FormPreferences(IParent mother)
        {
            // Preparing form
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Mother = mother;
            ManageLanguages();
            Translate();
            
            // Setting languages for translation
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO Save configurations
            buttonCancel_Click(sender, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageLanguages()
        {
            string[] languages = Mother.GetLanguages();
            foreach (string language in languages)
            {
                comboBoxLanguage.Items.Add(language);
            }
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void Translate()
        {
            labelAbout.Text = Mother.Get("About");
            textAbout.Text = Mother.Get("TextAbout");
            labelLanguage.Text = Mother.Get("Language");
            buttonCancel.Text = Mother.Get("Cancel");
        }
    }
}
