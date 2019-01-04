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
    public partial class Question : UserControl
    {
        public Question()
        {
            InitializeComponent();
        }

        private void Question_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width;
            Alternative defaultAlternative = new Alternative(1);
            this.alternativesPanel.Controls.Add(defaultAlternative);
        }

        private void alternativesPanel_SizeChanged(object sender, EventArgs e)
        {
            alternativesPanel.SuspendLayout();
            foreach (Control ctrl in alternativesPanel.Controls)
            {
                if (ctrl is Alternative) ctrl.Width = alternativesPanel.Width;
            }
            alternativesPanel.ResumeLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alternative defaultAlternative = new Alternative(this.alternativesPanel.Controls.Count + 1);
            this.alternativesPanel.Controls.Add(defaultAlternative);
        }
        public void updateLabelsAndRemoveControl(Control sender)
        {
            if(alternativesPanel.Controls.Count > 1)
            {
                alternativesPanel.Controls.Remove(sender);
                int count = 1;
                foreach (Control ctrl in alternativesPanel.Controls)
                {
                    if (ctrl is Alternative) ((Alternative)ctrl).updateLabel(count);
                    count++;
                }
                alternativesPanel.ResumeLayout();
            }
        }

        private void alternativesPanel_Paint(object sender, PaintEventArgs e)
        {
            this.alternativesPanel.Width = this.Width;
        }

        private void Question_SizeChanged(object sender, EventArgs e)
        {
            this.alternativesPanel.Width = this.Width;
        }

        public String getQuestionTitle()
        {
            return this.questionTitle.Text;
        }

        public List<ScalemateProject.Model.Alternative> getQuestionAlternatives()
        {
            int index = 1;
            List<ScalemateProject.Model.Alternative> questionAlternatives = new List<ScalemateProject.Model.Alternative>();
            foreach (Control ctrl in alternativesPanel.Controls)
            {
                Alternative alternative = (Alternative)ctrl;
                questionAlternatives.Add(new ScalemateProject.Model.Alternative(alternative.getAlternativeText(), index));
                index++;
            }
            return questionAlternatives;
            
        }
    }
}
