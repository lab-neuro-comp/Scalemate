namespace ScalemateProject.View.CreateScaleComponents
{
    partial class Group
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
            this.description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.minValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.maxValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.Depth = 0;
            this.description.Hint = "";
            this.description.Location = new System.Drawing.Point(90, 3);
            this.description.MaxLength = 32767;
            this.description.MouseState = MaterialSkin.MouseState.HOVER;
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.SelectedText = "";
            this.description.SelectionLength = 0;
            this.description.SelectionStart = 0;
            this.description.Size = new System.Drawing.Size(522, 23);
            this.description.TabIndex = 3;
            this.description.TabStop = false;
            this.description.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Resultado:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 36);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Valor mínimo:";
            // 
            // minValue
            // 
            this.minValue.Depth = 0;
            this.minValue.Hint = "";
            this.minValue.Location = new System.Drawing.Point(153, 32);
            this.minValue.MaxLength = 32767;
            this.minValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.minValue.Name = "minValue";
            this.minValue.PasswordChar = '\0';
            this.minValue.SelectedText = "";
            this.minValue.SelectionLength = 0;
            this.minValue.SelectionStart = 0;
            this.minValue.Size = new System.Drawing.Size(50, 23);
            this.minValue.TabIndex = 5;
            this.minValue.TabStop = false;
            this.minValue.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(43, 67);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Valor máximo:";
            // 
            // maxValue
            // 
            this.maxValue.Depth = 0;
            this.maxValue.Hint = "";
            this.maxValue.Location = new System.Drawing.Point(153, 63);
            this.maxValue.MaxLength = 32767;
            this.maxValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.maxValue.Name = "maxValue";
            this.maxValue.PasswordChar = '\0';
            this.maxValue.SelectedText = "";
            this.maxValue.SelectionLength = 0;
            this.maxValue.SelectionStart = 0;
            this.maxValue.Size = new System.Drawing.Size(50, 23);
            this.maxValue.TabIndex = 7;
            this.maxValue.TabStop = false;
            this.maxValue.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ScalemateProject.Properties.Resources.baseline_cancel_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(8, 103);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.button2.Size = new System.Drawing.Size(195, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "EXCLUIR ESCALA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.description);
            this.Name = "Group";
            this.Size = new System.Drawing.Size(615, 138);
            this.Load += new System.EventHandler(this.Group_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField description;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField minValue;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField maxValue;
        private System.Windows.Forms.Button button2;
    }
}
