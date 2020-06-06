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
            foreach (char a in codigo.ToCharArray()) //METODO PARA TRANSFORMAR STRING EN ARREGLO DE CHAR
            {
                cambio += (char)(-1 * a + 155);               //ENCAPSULAMIRNTO               
            }
            return cambio;
        }
    }
}
