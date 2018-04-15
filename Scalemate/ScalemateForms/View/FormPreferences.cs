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
        private IParent Mother;
        private string OriginalLanguage;

        public FormPreferences(IParent mother)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Mother = mother;
            OriginalLanguage = Mother.Get("ID");
            ManageLanguages();
            Translate();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Mother.Store();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Mother.Set(OriginalLanguage);
            this.Close();
        }

        private void comboxBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newLanguage = Mother.GetCodes()[comboBoxLanguage.SelectedIndex];
            Mother.Set(newLanguage);
            Translate();
        }
   
        private void ManageLanguages()
        {
            string[] codes = Mother.GetCodes();
            string[] languages = Mother.GetLanguages();
            int firstSelected = 0;

            for (int i = 0; i < languages.Length; ++i)
            {
                comboBoxLanguage.Items.Add(languages[i]);
                if (codes[i] == OriginalLanguage)
                {
                    firstSelected = i;
                }
            }
            comboBoxLanguage.SelectedIndex = firstSelected;
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
