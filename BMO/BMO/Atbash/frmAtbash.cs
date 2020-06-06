using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMO.Atbash
{
    public partial class frmAtbash : Form 
    {
        
        public frmAtbash()
        {
            InitializeComponent();
        }

        private void BtnCifrar_Click(object sender, EventArgs e)
        {
            MetodoAtbash at = new MetodoAtbash();
            txtEncriptadas.Items.Add(at.ZXY(txtPalabras.Text));
            txtResultados.Text = at.cambio;
        }       

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CriptogramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodosmsnAtbash ob = new MetodosmsnAtbash();
            this.Close();
            ob.AbrirCesar();
        }
    }
}
