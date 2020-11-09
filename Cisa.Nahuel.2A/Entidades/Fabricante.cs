using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabricante
    {
        private string marca;
        private EPais pais;

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

       public static implicit operator String(Fabricante f)
        {
            
            return f.marca + " - " + f.pais;
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            bool rta = false;

            if (string.Compare(a.marca,b.marca) == 0 && a.pais == b.pais)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            
            return !(a == b);
        }

    }
}
