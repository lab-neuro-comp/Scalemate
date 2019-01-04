namespace ScalemateProject.View.CreateScaleComponents
{
    partial class Question
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
            this.alternativesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.questionTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alternativesPanel
            // 
            this.alternativesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alternativesPanel.AutoSize = true;
            this.alternativesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.alternativesPanel.BackColor = System.Drawing.Color.White;
            this.alternativesPanel.Location = new System.Drawing.Point(0, 37);
            this.alternativesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.alternativesPanel.MinimumSize = new System.Drawing.Size(128, 32);
            this.alternativesPanel.Name = "alternativesPanel";
            this.alternativesPanel.Size = new System.Drawing.Size(128, 32);
            this.alternativesPanel.TabIndex = 0;
            this.alternativesPanel.SizeChanged += new System.EventHandler(this.alternativesPanel_SizeChanged);
            this.alternativesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.alternativesPanel_Paint);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 8);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Pergunta:";
            // 
            // questionTitle
            // 
            this.questionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionTitle.Depth = 0;
            this.questionTitle.Hint = "";
            this.questionTitle.Location = new System.Drawing.Point(81, 8);
            this.questionTitle.MaxLength = 32767;
            this.questionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.PasswordChar = '\0';
            this.questionTitle.SelectedText = "";
            this.questionTitle.SelectionLength = 0;
            this.questionTitle.SelectionStart = 0;
            this.questionTitle.Size = new System.Drawing.Size(643, 23);
            this.questionTitle.TabIndex = 2;
            this.questionTitle.TabStop = false;
            this.questionTitle.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ScalemateProject.Properties.Resources.baseline_cancel_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 89);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.button2.Size = new System.Drawing.Size(199, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "EXCLUIR PERGUNTA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ScalemateProject.Properties.Resources.baseline_note_add_24px1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(482, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.button1.Size = new System.Drawing.Size(231, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "ADICIONAR ALTERNATIVA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questionTitle);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.alternativesPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Question";
            this.Size = new System.Drawing.Size(727, 169);
            this.Load += new System.EventHandler(this.Question_Load);
            this.SizeChanged += new System.EventHandler(this.Question_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel alternativesPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField questionTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
