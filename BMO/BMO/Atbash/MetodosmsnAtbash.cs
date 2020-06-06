using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMO.Atbash
{
    class MetodosmsnAtbash : frmAtbash , IMenu
    {
        public new void Abrir(object obj)
        {
            Application.Run(new Cesar.frmCesar());
        }
        
        public void AbrirCesar()
        {
            Thread Ce = new Thread(Abrir);
            Ce.SetApartmentState(ApartmentState.STA);
            Ce.Start();
        }
    }
}
