using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scalemate.View
{
    public partial class FormPreferences : Form
    {
        private Form Mother { get; set; }

        public FormPreferences(Form mother)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Mother = mother;
        }
    }
}
