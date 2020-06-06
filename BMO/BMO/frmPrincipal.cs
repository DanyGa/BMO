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

namespace BMO
{
    public partial class frmPrincipal : Form
    {
        Thread Me;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            if (bgwBarra.IsBusy != true)
            {
                bgwBarra.RunWorkerAsync();
            }
        }

        private void BgwBarra_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                bgwBarra.ReportProgress(i * 10);
            }
        }

        private void BgwBarra_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgBarra.Value = e.ProgressPercentage;
        }

        private void BgwBarra_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            Me = new Thread(Otro);
            Me.SetApartmentState(ApartmentState.STA);
            Me.Start();
        }

        private void Otro(object obj)
        {
            Application.Run(new frmMenu());
        }
    }
}
