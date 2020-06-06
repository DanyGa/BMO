namespace BMO
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTema = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.prgBarra = new System.Windows.Forms.ProgressBar();
            this.lblBMO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgwBarra = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.White;
            this.lblTema.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(149, 110);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(352, 33);
            this.lblTema.TabIndex = 10;
            this.lblTema.Text = "Buenos Mensajes Ocultos";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(265, 236);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(131, 34);
            this.btnComenzar.TabIndex = 9;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // prgBarra
            // 
            this.prgBarra.ForeColor = System.Drawing.Color.LimeGreen;
            this.prgBarra.Location = new System.Drawing.Point(40, 170);
            this.prgBarra.Name = "prgBarra";
            this.prgBarra.Size = new System.Drawing.Size(565, 28);
            this.prgBarra.TabIndex = 8;
            this.prgBarra.UseWaitCursor = true;
            // 
            // lblBMO
            // 
            this.lblBMO.AutoSize = true;
            this.lblBMO.BackColor = System.Drawing.Color.Transparent;
            this.lblBMO.Font = new System.Drawing.Font("Britannic Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMO.Location = new System.Drawing.Point(227, 21);
            this.lblBMO.Name = "lblBMO";
            this.lblBMO.Size = new System.Drawing.Size(199, 89);
            this.lblBMO.TabIndex = 7;
            this.lblBMO.Text = "BMO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bgwBarra
            // 
            this.bgwBarra.WorkerReportsProgress = true;
            this.bgwBarra.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwBarra_DoWork);
            this.bgwBarra.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwBarra_ProgressChanged);
            this.bgwBarra.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwBarra_RunWorkerCompleted);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 293);
            this.ControlBox = false;
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.prgBarra);
            this.Controls.Add(this.lblBMO);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.ProgressBar prgBarra;
        private System.Windows.Forms.Label lblBMO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker bgwBarra;
    }
}

