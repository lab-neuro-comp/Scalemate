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
        private Form Mother { get; set; }

        public FormPreferences(Form mother)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Mother = mother;
            textAbout.Text = "ScalemateForms foi escrito por Cris Silva Jr. (http://www.crisjr.eng.br) no Laboratório de Neurociência e Comportamento da Universidade de Brasília, e foi lançado sob a licença MIT (https://opensource.org/licenses/MIT).";
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
    }
}
