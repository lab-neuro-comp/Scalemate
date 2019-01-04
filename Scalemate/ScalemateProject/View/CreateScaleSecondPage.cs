using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScalemateProject.Model;
using Newtonsoft.Json;
using ScalemateProject.Controls;

namespace ScalemateProject.View
{
    public partial class CreateScaleSecondPage : UserControl
    {
        private Control firstPage;
        private Scale scale;
        public CreateScaleSecondPage(Control firstPage, Scale scale)
        {
            this.firstPage = firstPage;
            this.scale = scale;
            InitializeComponent();
        }

        private void CreateScaleSecondPage_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(firstPage);
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateScaleComponents.Group group = new CreateScaleComponents.Group();
            groupPanel.Controls.Add(group);
        }

        private void CreateScaleSecondPage_SizeChanged(object sender, EventArgs e)
        {
            this.groupPanel.Width = this.Width;
        }

        private void groupPanel_SizeChanged(object sender, EventArgs e)
        {
            groupPanel.SuspendLayout();
            foreach (Control ctrl in groupPanel.Controls)
            {
                ctrl.Width = groupPanel.Width - 16;
            }
            groupPanel.ResumeLayout();
        }

        private void updateButton()
        {
            bool shouldBeEnabled = true;
            if (this.groupPanel.Controls.Count == 0)
            {
                shouldBeEnabled = false;
            }
            this.saveButton.Enabled = shouldBeEnabled;
        }

        private void groupPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            updateButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<Group> groups = new List<Group>();
            foreach (Control ctrl in groupPanel.Controls)
            {
                CreateScaleComponents.Group groupView = (CreateScaleComponents.Group)ctrl;
                groups.Add(groupView.getGroup());
            }
            this.scale.Groups = groups;
            FileManager.SaveScale(this.scale);
            this.Parent.Controls.Remove(this);
        }
    }
}
