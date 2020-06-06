using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMO.Atbash
{
    class MetodoAtbash
    {
        public String cambio;
        public String ZXY(String codigo)
        {
            foreach (char a in codigo.ToCharArray()) 
            {
                cambio += (char)(-1 * a + 155);
            }
            return cambio;
        }
    }
}
