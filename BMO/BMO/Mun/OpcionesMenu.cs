using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMO.Mun
{
    class OpcionesMenu : frmMenu , IMenuPrincipal
    {
        public void Open(object obj)
        {
            Application.Run(new Atbash.frmAtbash());
        }
        public void Aperto(object obj)
        {
            Application.Run(new Cesar.frmCesar());            
        }

        public void OpenAtbash()
        {
            Thread AZ = new Thread(Open);
            AZ.SetApartmentState(ApartmentState.STA);
            AZ.Start();
        }

        public void ApertoCesar()
        {
            Thread Ce = new Thread(Aperto);
            Ce.SetApartmentState(ApartmentState.STA);
            Ce.Start();
        }
    }
}
