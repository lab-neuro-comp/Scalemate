namespace ScalemateProject.View
{
    partial class CreateScaleFirstPage
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
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.scaleNameText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.nextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(123, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Nome da Escala:";
            // 
            // scaleNameText
            // 
            this.scaleNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleNameText.Depth = 0;
            this.scaleNameText.Hint = "";
            this.scaleNameText.Location = new System.Drawing.Point(132, 79);
            this.scaleNameText.MaxLength = 32767;
            this.scaleNameText.MouseState = MaterialSkin.MouseState.HOVER;
            this.scaleNameText.Name = "scaleNameText";
            this.scaleNameText.PasswordChar = '\0';
            this.scaleNameText.SelectedText = "";
            this.scaleNameText.SelectionLength = 0;
            this.scaleNameText.SelectionStart = 0;
            this.scaleNameText.Size = new System.Drawing.Size(563, 23);
            this.scaleNameText.TabIndex = 6;
            this.scaleNameText.TabStop = false;
            this.scaleNameText.UseSystemPasswordChar = false;
            this.scaleNameText.TextChanged += new System.EventHandler(this.scaleNameText_TextChanged);
            // 
            // questionsPanel
            // 
            this.questionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsPanel.AutoScroll = true;
            this.questionsPanel.BackColor = System.Drawing.Color.White;
            this.questionsPanel.Location = new System.Drawing.Point(0, 126);
            this.questionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.questionsPanel.Size = new System.Drawing.Size(699, 231);
            this.questionsPanel.TabIndex = 7;
            this.questionsPanel.SizeChanged += new System.EventHandler(this.questionsPanel_SizeChanged);
            this.questionsPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.questionsPanel_ControlAdded);
            this.questionsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.questionsPanel_ControlRemoved);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Image = global::ScalemateProject.Properties.Resources.Vector;
            this.nextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nextButton.Location = new System.Drawing.Point(577, 20);
            this.nextButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.nextButton.Size = new System.Drawing.Size(118, 32);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "AVANÇAR";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ScalemateProject.Properties.Resources.baseline_note_add_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADICIONAR PERGUNTA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.Black;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-4, 122);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(699, 1);
            this.materialDivider2.TabIndex = 8;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // CreateScaleFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.questionsPanel);
            this.Controls.Add(this.scaleNameText);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateScaleFirstPage";
            this.Size = new System.Drawing.Size(698, 357);
            this.SizeChanged += new System.EventHandler(this.CreateScaleFirstPage_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField scaleNameText;
        private System.Windows.Forms.FlowLayoutPanel questionsPanel;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}
