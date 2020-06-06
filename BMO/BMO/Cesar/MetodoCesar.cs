using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMO.Cesar
{
    class MetodoCesar : frmCesar 
    {       
        public String cambio;
        public String Cifrar(string codigo)
        {
            foreach (char ch in codigo.ToCharArray())
            {
                cambio += (char)(ch + 3);
            } return cambio;
        }

        public void DecifrarCadena()
        {
            int t, letras;
            string cadena = txtPalabras.Text;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t - 3);
                txtCyD.Items.Add(ch[i]);
            }
        }

        public String Decifrar(string codigo)
        {
            foreach (char ch in codigo.ToCharArray())
            {
                cambio += (char)(ch - 3);
            }
            return cambio;
        }
        public void Lim()
        {
            txtCyD.Items.Clear();
        }

    }
}
