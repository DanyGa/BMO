namespace BMO
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCesar = new System.Windows.Forms.Button();
            this.btnAtbash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBMO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(235, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 34);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCesar
            // 
            this.btnCesar.BackColor = System.Drawing.Color.White;
            this.btnCesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCesar.Location = new System.Drawing.Point(370, 198);
            this.btnCesar.Name = "btnCesar";
            this.btnCesar.Size = new System.Drawing.Size(107, 37);
            this.btnCesar.TabIndex = 19;
            this.btnCesar.Text = "Cesar";
            this.btnCesar.UseVisualStyleBackColor = false;
            this.btnCesar.Click += new System.EventHandler(this.BtnCesar_Click);
            // 
            // btnAtbash
            // 
            this.btnAtbash.BackColor = System.Drawing.Color.White;
            this.btnAtbash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtbash.Location = new System.Drawing.Point(81, 198);
            this.btnAtbash.Name = "btnAtbash";
            this.btnAtbash.Size = new System.Drawing.Size(100, 37);
            this.btnAtbash.TabIndex = 18;
            this.btnAtbash.Text = "Atbash";
            this.btnAtbash.UseVisualStyleBackColor = false;
            this.btnAtbash.Click += new System.EventHandler(this.BtnAtbash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "seleccione una opcion para empezar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buenos Mensajes Ocultos";
            // 
            // lblBMO
            // 
            this.lblBMO.AutoSize = true;
            this.lblBMO.BackColor = System.Drawing.Color.White;
            this.lblBMO.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMO.Location = new System.Drawing.Point(202, 9);
            this.lblBMO.Name = "lblBMO";
            this.lblBMO.Size = new System.Drawing.Size(150, 67);
            this.lblBMO.TabIndex = 15;
            this.lblBMO.Text = "BMO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCesar);
            this.Controls.Add(this.btnAtbash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBMO);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCesar;
        private System.Windows.Forms.Button btnAtbash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBMO;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}