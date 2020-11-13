using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sacapunta-> deMetal:bool(público); 
//Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

namespace Entidades
{
    public class Sacapunta : Utiles
    {
        
        public bool deMetal;
        public override bool PreciosCuidados { get { return false; } }

        public Sacapunta(bool metal, double precio, string marca)
        :base(marca, precio)
        {
            this.deMetal = metal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat($"De Metal: {this.deMetal}\nPrecio Cuidado {this.PreciosCuidados}");

            return sb.ToString();
        }
    }
}
