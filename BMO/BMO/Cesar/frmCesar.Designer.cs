namespace BMO.Cesar
{
    partial class frmCesar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCesar));
            this.txtCyD = new System.Windows.Forms.ListBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.btnDesifrar = new System.Windows.Forms.Button();
            this.lblCyD = new System.Windows.Forms.Label();
            this.mnsCesar = new System.Windows.Forms.MenuStrip();
            this.AtbashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.lblAtbash = new System.Windows.Forms.Label();
            this.lblBMO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnsCesar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCyD
            // 
            this.txtCyD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCyD.FormattingEnabled = true;
            this.txtCyD.ItemHeight = 16;
            this.txtCyD.Location = new System.Drawing.Point(96, 310);
            this.txtCyD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCyD.Name = "txtCyD";
            this.txtCyD.Size = new System.Drawing.Size(256, 176);
            this.txtCyD.TabIndex = 16;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(67, 196);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(100, 28);
            this.btnCifrar.TabIndex = 14;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.BtnCifrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 562);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(96, 109);
            this.txtPalabras.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalabras.Multiline = true;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(256, 47);
            this.txtPalabras.TabIndex = 13;
            // 
            // btnDesifrar
            // 
            this.btnDesifrar.Location = new System.Drawing.Point(279, 196);
            this.btnDesifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesifrar.Name = "btnDesifrar";
            this.btnDesifrar.Size = new System.Drawing.Size(100, 28);
            this.btnDesifrar.TabIndex = 15;
            this.btnDesifrar.Text = "Desifrar";
            this.btnDesifrar.UseVisualStyleBackColor = true;
            this.btnDesifrar.Click += new System.EventHandler(this.BtnDesifrar_Click);
            // 
            // lblCyD
            // 
            this.lblCyD.AutoSize = true;
            this.lblCyD.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyD.Location = new System.Drawing.Point(172, 230);
            this.lblCyD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCyD.Name = "lblCyD";
            this.lblCyD.Size = new System.Drawing.Size(103, 29);
            this.lblCyD.TabIndex = 18;
            this.lblCyD.Text = "Cifrado";
            // 
            // mnsCesar
            // 
            this.mnsCesar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsCesar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AtbashToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnsCesar.Location = new System.Drawing.Point(0, 0);
            this.mnsCesar.Name = "mnsCesar";
            this.mnsCesar.Size = new System.Drawing.Size(478, 28);
            this.mnsCesar.TabIndex = 19;
            this.mnsCesar.Text = "mnsCesar";
            // 
            // AtbashToolStripMenuItem
            // 
            this.AtbashToolStripMenuItem.Name = "AtbashToolStripMenuItem";
            this.AtbashToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.AtbashToolStripMenuItem.Text = "Atbash";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(96, 281);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(256, 22);
            this.txtResultados.TabIndex = 29;
            // 
            // lblAtbash
            // 
            this.lblAtbash.AutoSize = true;
            this.lblAtbash.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtbash.Location = new System.Drawing.Point(184, 46);
            this.lblAtbash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtbash.Name = "lblAtbash";
            this.lblAtbash.Size = new System.Drawing.Size(77, 29);
            this.lblAtbash.TabIndex = 31;
            this.lblAtbash.Text = "Cesar";
            // 
            // lblBMO
            // 
            this.lblBMO.AutoSize = true;
            this.lblBMO.BackColor = System.Drawing.Color.White;
            this.lblBMO.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMO.Location = new System.Drawing.Point(369, 500);
            this.lblBMO.Name = "lblBMO";
            this.lblBMO.Size = new System.Drawing.Size(95, 42);
            this.lblBMO.TabIndex = 32;
            this.lblBMO.Text = "BMO";
            // 
            // frmCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 557);
            this.Controls.Add(this.lblBMO);
            this.Controls.Add(this.lblAtbash);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.mnsCesar);
            this.Controls.Add(this.lblCyD);
            this.Controls.Add(this.txtCyD);
            this.Controls.Add(this.btnDesifrar);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.txtPalabras);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.mnsCesar;
            this.MaximizeBox = false;
            this.Name = "frmCesar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCesar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnsCesar.ResumeLayout(false);
            this.mnsCesar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox txtCyD;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Button btnDesifrar;
        private System.Windows.Forms.Label lblCyD;
        private System.Windows.Forms.MenuStrip mnsCesar;
        private System.Windows.Forms.ToolStripMenuItem AtbashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label lblAtbash;
        private System.Windows.Forms.Label lblBMO;
    }
}