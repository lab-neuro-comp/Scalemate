namespace ScalemateProject.View
{
    partial class CreateScaleSecondPage
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
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.button3 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.Black;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(3, 44);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(624, 1);
            this.materialDivider2.TabIndex = 9;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::ScalemateProject.Properties.Resources.back;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(406, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.button3.Size = new System.Drawing.Size(110, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "VOLTAR";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::ScalemateProject.Properties.Resources.save;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(516, 9);
            this.saveButton.Margin = new System.Windows.Forms.Padding(0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.saveButton.Size = new System.Drawing.Size(114, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "SALVAR";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ScalemateProject.Properties.Resources.baseline_note_add_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADICIONAR ESCALA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupPanel
            // 
            this.groupPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel.AutoScroll = true;
            this.groupPanel.Location = new System.Drawing.Point(3, 51);
            this.groupPanel.Margin = new System.Windows.Forms.Padding(0);
            this.groupPanel.Name = "groupPanel";
            this.groupPanel.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.groupPanel.Size = new System.Drawing.Size(627, 200);
            this.groupPanel.TabIndex = 10;
            this.groupPanel.SizeChanged += new System.EventHandler(this.groupPanel_SizeChanged);
            this.groupPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.groupPanel_ControlAdded);
            this.groupPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.groupPanel_ControlAdded);
            // 
            // CreateScaleSecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupPanel);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CreateScaleSecondPage";
            this.Size = new System.Drawing.Size(630, 251);
            this.Load += new System.EventHandler(this.CreateScaleSecondPage_Load);
            this.SizeChanged += new System.EventHandler(this.CreateScaleSecondPage_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.FlowLayoutPanel groupPanel;
    }
}
