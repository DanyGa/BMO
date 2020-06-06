using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMO
{
    public partial class frmMenu : Form 
    {
       
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnAtbash_Click(object sender, EventArgs e)
        {
            Mun.OpcionesMenu ob = new Mun.OpcionesMenu();
            this.Close();
            ob.OpenAtbash();
        }

        private void BtnCesar_Click(object sender, EventArgs e)
        {
            Mun.OpcionesMenu ok = new Mun.OpcionesMenu();
            this.Close();
            ok.ApertoCesar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
