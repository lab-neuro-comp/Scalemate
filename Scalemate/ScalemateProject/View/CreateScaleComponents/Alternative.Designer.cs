namespace ScalemateProject.View.CreateScaleComponents
{
    partial class Alternative
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
            this.optionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.optionValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Depth = 0;
            this.optionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.optionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.optionLabel.Location = new System.Drawing.Point(35, 3);
            this.optionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(67, 19);
            this.optionLabel.TabIndex = 1;
            this.optionLabel.Text = "Opção x:";
            // 
            // optionValue
            // 
            this.optionValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionValue.Depth = 0;
            this.optionValue.Hint = "";
            this.optionValue.Location = new System.Drawing.Point(108, 3);
            this.optionValue.MaxLength = 32767;
            this.optionValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionValue.Name = "optionValue";
            this.optionValue.PasswordChar = '\0';
            this.optionValue.SelectedText = "";
            this.optionValue.SelectionLength = 0;
            this.optionValue.SelectionStart = 0;
            this.optionValue.Size = new System.Drawing.Size(346, 23);
            this.optionValue.TabIndex = 2;
            this.optionValue.TabStop = false;
            this.optionValue.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ScalemateProject.Properties.Resources.baseline_close_24px;
            this.pictureBox1.InitialImage = global::ScalemateProject.Properties.Resources.baseline_close_24px;
            this.pictureBox1.Location = new System.Drawing.Point(432, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Alternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.optionValue);
            this.Controls.Add(this.optionLabel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Alternative";
            this.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.Size = new System.Drawing.Size(457, 28);
            this.Load += new System.EventHandler(this.Alternative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel optionLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField optionValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
