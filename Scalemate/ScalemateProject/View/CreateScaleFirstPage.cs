using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScalemateProject.View.CreateScaleComponents;

namespace ScalemateProject.View
{
    public partial class CreateScaleFirstPage : UserControl
    {
        public CreateScaleFirstPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void CreateScale_Load(object sender, EventArgs e)
        {

        }

        private void updateButton()
        {
            bool shouldBeEnabled = true;
            if (this.questionsPanel.Controls.Count == 0 || this.scaleNameText.Text.Length == 0)
            {
                shouldBeEnabled = false;
            }
            this.nextButton.Enabled = shouldBeEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            this.questionsPanel.Controls.Add(question);
        }

        private void questionsPanel_SizeChanged(object sender, EventArgs e)
        {
            questionsPanel.SuspendLayout();
            foreach (Control ctrl in questionsPanel.Controls)
            {
                if (ctrl is Question) ctrl.Width = questionsPanel.Width-16;
            }
            questionsPanel.ResumeLayout();
        }

        private void CreateScaleFirstPage_SizeChanged(object sender, EventArgs e)
        {
            this.questionsPanel.Width = this.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List <ScalemateProject.Model.Question> questionList = new List<ScalemateProject.Model.Question>();
            foreach (Control ctrl in questionsPanel.Controls)
            {
                Question question = (Question)ctrl;
                String questionTitle = question.getQuestionTitle();
                List<ScalemateProject.Model.Alternative> questionAlternatives = question.getQuestionAlternatives();
                ScalemateProject.Model.Question questionObject = new ScalemateProject.Model.Question(questionTitle, questionAlternatives);
                questionList.Add(questionObject);
            }
            ScalemateProject.Model.Scale scale = new ScalemateProject.Model.Scale(questionList);
            scale.Name = scaleNameText.Text;
            CreateScaleSecondPage secondPage = new CreateScaleSecondPage(this, scale);
            this.Parent.Controls.Add(secondPage);
            this.Parent.Controls.Remove(this);
        }

        private void questionsPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            updateButton();
        }

        private void questionsPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            updateButton();
        }

        private void scaleNameText_TextChanged(object sender, EventArgs e)
        {
            updateButton();
        }
    }
}
