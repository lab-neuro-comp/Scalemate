namespace ScalemateProject
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.executeScaleBtn = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createScaleBtn = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editScaleBtn = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resultsBtn = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainPanel.Controls.Add(this.panel1, 0, 0);
            this.mainPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainPanel.Size = new System.Drawing.Size(800, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.resultsBtn);
            this.panel1.Controls.Add(this.editScaleBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.createScaleBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.executeScaleBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // executeScaleBtn
            // 
            this.executeScaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeScaleBtn.Depth = 0;
            this.executeScaleBtn.Font = new System.Drawing.Font("Roboto", 11F);
            this.executeScaleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.executeScaleBtn.Location = new System.Drawing.Point(0, 5);
            this.executeScaleBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.executeScaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.executeScaleBtn.Name = "executeScaleBtn";
            this.executeScaleBtn.Padding = new System.Windows.Forms.Padding(16, 6, 16, 0);
            this.executeScaleBtn.Size = new System.Drawing.Size(147, 30);
            this.executeScaleBtn.TabIndex = 0;
            this.executeScaleBtn.Text = "Executar Escala";
            this.executeScaleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.executeScaleBtn.Click += new System.EventHandler(this.executeScaleBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(147, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 22);
            this.panel2.TabIndex = 1;
            // 
            // createScaleBtn
            // 
            this.createScaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createScaleBtn.Depth = 0;
            this.createScaleBtn.Font = new System.Drawing.Font("Roboto", 11F);
            this.createScaleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createScaleBtn.Location = new System.Drawing.Point(148, 5);
            this.createScaleBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.createScaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createScaleBtn.Name = "createScaleBtn";
            this.createScaleBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.createScaleBtn.Size = new System.Drawing.Size(147, 30);
            this.createScaleBtn.TabIndex = 2;
            this.createScaleBtn.Text = "Criar Escala";
            this.createScaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createScaleBtn.Click += new System.EventHandler(this.createScaleBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(295, 9);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 22);
            this.panel3.TabIndex = 3;
            // 
            // editScaleBtn
            // 
            this.editScaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editScaleBtn.Depth = 0;
            this.editScaleBtn.Font = new System.Drawing.Font("Roboto", 11F);
            this.editScaleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editScaleBtn.Location = new System.Drawing.Point(296, 5);
            this.editScaleBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.editScaleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editScaleBtn.Name = "editScaleBtn";
            this.editScaleBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.editScaleBtn.Size = new System.Drawing.Size(147, 30);
            this.editScaleBtn.TabIndex = 4;
            this.editScaleBtn.Text = "Editar Escala";
            this.editScaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.editScaleBtn.Click += new System.EventHandler(this.editScaleBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(443, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 22);
            this.panel4.TabIndex = 5;
            // 
            // resultsBtn
            // 
            this.resultsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultsBtn.Depth = 0;
            this.resultsBtn.Font = new System.Drawing.Font("Roboto", 11F);
            this.resultsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultsBtn.Location = new System.Drawing.Point(444, 5);
            this.resultsBtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.resultsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.resultsBtn.Size = new System.Drawing.Size(147, 30);
            this.resultsBtn.TabIndex = 6;
            this.resultsBtn.Text = "Resultados";
            this.resultsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultsBtn.Click += new System.EventHandler(this.resultsBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "Scalemate";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel executeScaleBtn;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel resultsBtn;
        private MaterialSkin.Controls.MaterialLabel editScaleBtn;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel createScaleBtn;
        private System.Windows.Forms.Panel panel3;
    }
}

