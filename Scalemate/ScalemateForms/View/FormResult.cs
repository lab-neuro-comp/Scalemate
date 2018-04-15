using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scalemate;
using ScalemateForms.View.Util;

namespace ScalemateForms.View
{
    public partial class FormResult : Form
    {
        public IParent Mother { get; set; }
        public Tester Mate { get; set; }

        public FormResult(IParent mother, Tester mate)
        {
            Mother = mother;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Mate = mate;
            this.UpdateInstructions();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Mother.Show();
            this.Close();
        }
        
    }
}
