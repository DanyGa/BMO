using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMO.Cesar
{
    class MetodosmnsCesar : frmCesar , IMenu
    {
        public void Abrir(object obj)
        {
            Application.Run(new Atbash.frmAtbash());            
        }


        public void AbrirAtbash()
        {
            Thread At = new Thread(Abrir);
            At.SetApartmentState(ApartmentState.STA);
            At.Start();
        }
    }
}
