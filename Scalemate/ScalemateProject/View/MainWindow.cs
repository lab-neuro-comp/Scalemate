using ScalemateProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalemateProject
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyClickedStyleAndRemoveControls(Control button)
        {
            this.createScaleBtn.BackColor = System.Drawing.Color.Transparent;
            this.editScaleBtn.BackColor = System.Drawing.Color.Transparent;
            this.resultsBtn.BackColor = System.Drawing.Color.Transparent;
            this.executeScaleBtn.BackColor = System.Drawing.Color.Transparent;
            button.BackColor = System.Drawing.Color.FromArgb(12, 0, 0, 0);

            // delete all controls of 2nd ROW
            this.mainPanel.Controls.Remove(this.mainPanel.GetControlFromPosition(0, 1));
        }

        private void executeScaleBtn_Click(object sender, EventArgs e)
        {
            applyClickedStyleAndRemoveControls((Control)sender);
        }

        private void createScaleBtn_Click(object sender, EventArgs e)
        {
            applyClickedStyleAndRemoveControls((Control)sender);
            CreateScaleFirstPage userControl = new CreateScaleFirstPage();
            this.mainPanel.Controls.Add(userControl);
        }

        private void editScaleBtn_Click(object sender, EventArgs e)
        {
            applyClickedStyleAndRemoveControls((Control)sender);

        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
            applyClickedStyleAndRemoveControls((Control)sender);

        }
    }
}
