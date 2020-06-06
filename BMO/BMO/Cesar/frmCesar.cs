using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMO.Cesar
{
    public partial class frmCesar : Form 
    {             
        public frmCesar()
        {
            InitializeComponent();           
        }        
        
        private void BtnCifrar_Click(object sender, EventArgs e)
        {
            MetodoCesar al = new MetodoCesar();           
            txtCyD.Items.Add(al.Cifrar(txtPalabras.Text));
            txtResultados.Text = al.cambio;
            lblCyD.Text = "Cifrado";
        }

        private void BtnDesifrar_Click(object sender, EventArgs e)
        {
            MetodoCesar at = new MetodoCesar();
            at.Lim();
            txtCyD.Items.Add(at.Decifrar(txtPalabras.Text));
            txtResultados.Text = at.cambio;
            lblCyD.Text = "Decifrado";
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AtbashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetodosmnsCesar ob = new MetodosmnsCesar();
            this.Close();
            ob.AbrirAtbash();
        }
    }
}
