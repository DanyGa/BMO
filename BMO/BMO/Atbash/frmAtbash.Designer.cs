namespace BMO.Atbash
{
    partial class frmAtbash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAtbash));
            this.txtEncriptadas = new System.Windows.Forms.ListBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.lblAtbash = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.mnsAtbash = new System.Windows.Forms.MenuStrip();
            this.criptogramasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.lblBMO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnsAtbash.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncriptadas
            // 
            this.txtEncriptadas.FormattingEnabled = true;
            this.txtEncriptadas.ItemHeight = 16;
            this.txtEncriptadas.Location = new System.Drawing.Point(297, 270);
            this.txtEncriptadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncriptadas.Name = "txtEncriptadas";
            this.txtEncriptadas.Size = new System.Drawing.Size(197, 148);
            this.txtEncriptadas.TabIndex = 24;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(348, 192);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(100, 28);
            this.btnCifrar.TabIndex = 23;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.BtnCifrar_Click);
            // 
            // lblAtbash
            // 
            this.lblAtbash.AutoSize = true;
            this.lblAtbash.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtbash.Location = new System.Drawing.Point(352, 42);
            this.lblAtbash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtbash.Name = "lblAtbash";
            this.lblAtbash.Size = new System.Drawing.Size(96, 29);
            this.lblAtbash.TabIndex = 22;
            this.lblAtbash.Text = "Atbash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(297, 241);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(197, 22);
            this.txtResultados.TabIndex = 28;
            // 
            // txtPalabras
            // 
            this.txtPalabras.Location = new System.Drawing.Point(267, 119);
            this.txtPalabras.Margin = new System.Windows.Forms.Padding(4);
            this.txtPalabras.Multiline = true;
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(256, 47);
            this.txtPalabras.TabIndex = 28;
            // 
            // mnsAtbash
            // 
            this.mnsAtbash.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsAtbash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criptogramasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.mnsAtbash.Location = new System.Drawing.Point(0, 0);
            this.mnsAtbash.Name = "mnsAtbash";
            this.mnsAtbash.Size = new System.Drawing.Size(800, 28);
            this.mnsAtbash.TabIndex = 29;
            this.mnsAtbash.Text = "menuStrip1";
            // 
            // criptogramasToolStripMenuItem
            // 
            this.criptogramasToolStripMenuItem.Name = "criptogramasToolStripMenuItem";
            this.criptogramasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.criptogramasToolStripMenuItem.Text = "Cesar";
            this.criptogramasToolStripMenuItem.Click += new System.EventHandler(this.CriptogramasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(283, 86);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(221, 18);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "USAR LETRAS EN MAYUSCULA";
            // 
            // lblBMO
            // 
            this.lblBMO.AutoSize = true;
            this.lblBMO.BackColor = System.Drawing.Color.White;
            this.lblBMO.Font = new System.Drawing.Font("Britannic Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMO.Location = new System.Drawing.Point(693, 399);
            this.lblBMO.Name = "lblBMO";
            this.lblBMO.Size = new System.Drawing.Size(95, 42);
            this.lblBMO.TabIndex = 33;
            this.lblBMO.Text = "BMO";
            // 
            // frmAtbash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBMO);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.txtPalabras);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.txtEncriptadas);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.lblAtbash);
            this.Controls.Add(this.mnsAtbash);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.mnsAtbash;
            this.MaximizeBox = false;
            this.Name = "frmAtbash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtbash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnsAtbash.ResumeLayout(false);
            this.mnsAtbash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox txtEncriptadas;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Label lblAtbash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.MenuStrip mnsAtbash;
        private System.Windows.Forms.ToolStripMenuItem criptogramasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Label lblBMO;
    }
}