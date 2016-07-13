using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scalemate.Model;
using Scalemate.Controller;

namespace Scalemate.View
{
    partial class FormInventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

            if (!Mate.Ended) Mother.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Table, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonContinue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelQuestion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(3, 42);
            this.Table.Name = "Table";
            this.Table.RowCount = 1;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Table.Size = new System.Drawing.Size(416, 307);
            this.Table.TabIndex = 0;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonContinue.Location = new System.Drawing.Point(173, 360);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continuar";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(416, 39);
            this.labelQuestion.TabIndex = 2;
            this.labelQuestion.Text = "Question here...";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormInventory";
            this.Text = "FormInventory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Procedures before testing

        public async Task<bool> Instruct()
        {
            FormInstructions instructions = new FormInstructions();
            bool areThereInstructions = Mate.AreThereInstructions();

            if (areThereInstructions)
            {
                areThereInstructions = true;
                instructions.SetInstructions(Mate.LoadInstructions());
                instructions.Show();
                while (!instructions.Ended)
                {
                    await Task.Delay(10);
                }
            }

            instructions.Close();
            return areThereInstructions;
        }

        public async Task<bool> CollectInformation()
        {
            var form = new FormData();
            var isThereInformation = Mate.IsThereSurvey();

            if (isThereInformation)
            {
                isThereInformation = true;
                form.SetQuestions(Mate.LoadSurvey());
                form.Show();
                while (!form.Ended)
                    await Task.Delay(10);
                Mate.Survey = form.Survey;
            }

            form.Close();
            return isThereInformation;
        }

        #endregion

        #region Ambient setup
        private RadioButton[] Radios { get; set; }

        private void CreateRows()
        {
            Table.RowCount = NoOptions;
            Radios = new RadioButton[NoOptions];

            Table.RowStyles.Clear();
            Table.RowCount = NoOptions;
            for (int i = 0; i < NoOptions; i++)
            {
                RadioButton radio = new RadioButton();

                radio.Anchor = AnchorStyles.None;
                radio.AutoSize = true;
                radio.UseVisualStyleBackColor = true;
                radio.TabIndex = i + 1;

                Radios[i] = radio;
                Table.Controls.Add(Radios[i], 0, i);
                Table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / NoOptions));
            }

            Radios[0].Checked = true;
        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelQuestion;
    }
}