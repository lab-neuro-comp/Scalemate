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
    public partial class Group : UserControl
    {
        public Group()
        {
            InitializeComponent();
        }

        private void Group_Load(object sender, EventArgs e)
        {

            this.Width = this.Parent.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public Model.Group getGroup()
        {
            Model.Group group = new Model.Group(this.description.Text, Int32.Parse(this.minValue.Text), Int32.Parse(this.maxValue.Text));
            return group;
        }
    }
}
