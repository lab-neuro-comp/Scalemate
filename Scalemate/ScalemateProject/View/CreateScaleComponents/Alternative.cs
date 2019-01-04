using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalemateProject.View.CreateScaleComponents
{
    public partial class Alternative : UserControl
    {
        private int optionNumber;
        public Alternative(int optionNumber)
        {
            InitializeComponent();
            this.optionNumber = optionNumber;
        }

        private void Alternative_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            this.optionLabel.Text = "Opção " + optionNumber + ":";
        }
        public void updateLabel(int newNum)
        {
            this.optionLabel.Text = "Opção " + newNum + ":";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ((Question)this.Parent.Parent).updateLabelsAndRemoveControl(this);
        }
        public String getAlternativeText()
        {
            return this.optionValue.Text;
        }
    }
}
