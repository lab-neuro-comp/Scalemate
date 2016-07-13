using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scalemate.Controller;

namespace Scalemate.View
{
    public partial class FormResult : Form
    {
        public Form Mother { get; set; }
        public Tester Mate { get; set; }

        public FormResult()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
