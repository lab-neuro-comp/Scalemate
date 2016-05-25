using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scalemate
{
    partial class FormInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private RadioButton[] Radios { get; set; }
        private Label[] Labels { get; set; }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventory));
            this.flowLayoutPanel1 = new FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif",
                                                              12F,
                                                              System.Drawing.FontStyle.Regular,
                                                              System.Drawing.GraphicsUnit.Point,
                                                              ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(this.Width / 2, this.Height / 4);
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // buttonContinue
            // 
            //this.buttonContinue.Location = new System.Drawing.Point(3, 206);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 25);
            this.buttonContinue.TabIndex = NoQuestions + 1;
            this.buttonContinue.Text = "Continuar";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Anchor = AnchorStyles.None;
            this.tableLayoutPanel1.Width = this.Width;
            this.tableLayoutPanel1.Height = this.Height / 2; // if this guy and the question label are too big, the button disappear

            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelQuestion);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.buttonContinue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Anchor = AnchorStyles.None;
            //this.flowLayoutPanel1.Dock = DockStyle.Fill;
            this.flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            // Let's try this the hard way
            this.flowLayoutPanel1.Width = this.Width;
            this.flowLayoutPanel1.Height = this.Height;

            //this.flowLayoutPanel1.Left = (this.ClientSize.Width - this.flowLayoutPanel1.Width);
            //this.flowLayoutPanel1.Top = (this.ClientSize.Height - this.flowLayoutPanel1.Height);

            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormInventory";
            this.Text = "Scalemate";
            this.Icon = new System.Drawing.Icon(@"assets\Logo.ico");
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region My own code

        private string[] Rest(string[] array)
        {
            int limit = array.Length - 1;
            string[] outlet = new string[limit];

            for (int i = 1; i < array.Length; i++)
            {
                outlet[i - 1] = array[i];
            }

            return outlet;
        }

        private void CreateRows()
        {
            tableLayoutPanel1.RowCount = NoQuestions;
            Radios = new RadioButton[NoQuestions];
            Labels = new Label[NoQuestions];

            for (int i = 0; i < NoQuestions; i++)
            {
                RadioButton radio = new RadioButton();
                Label label = new Label();

                radio.Anchor = AnchorStyles.None;
                radio.AutoSize = true;
                radio.UseVisualStyleBackColor = true;
                radio.TabIndex = i + 1;
                label.Anchor = AnchorStyles.Left;
                label.AutoSize = true;

                Radios[i] = radio;
                Labels[i] = label;
                tableLayoutPanel1.Controls.Add(Radios[i], 0, i);
                tableLayoutPanel1.Controls.Add(Labels[i], 1, i);
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / NoQuestions));
            }

            Radios[0].Checked = true;
        }

        public async Task<bool> Instruct()
        {
            FormInstructions instructions = new FormInstructions();
            DataAcessLayer DAL = new DataAcessLayer();
            string instructionsPath = DAL.GetInstructionsPath(Test);

            if (DAL.FileExists(instructionsPath))
            {
                instructions.SetInstructions(DAL.Load(instructionsPath)
                                                .Aggregate((acc, it) => acc + "\n" + it));
                instructions.Show();
                while (!instructions.Ended)
                {
                    await Task.Delay(10);
                }
            }
            
            this.Show();
            instructions.Close();
            return true;
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonContinue;
        private Label labelQuestion;
    }
}

