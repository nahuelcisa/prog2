using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Goma-> soloLapiz:bool(público); PreciosCuidados->true; 
//Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

namespace Entidades
{
    public class Goma : Utiles
    {
        public bool soloLapiz;

        public override bool PreciosCuidados { get { return true; } }

        public Goma(bool lapiz, string marca, double precio)
        :base(marca, precio)
        {
            this.soloLapiz = lapiz;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat($"SoloLapiz: {this.soloLapiz}\nPrecio Cuidado {this.PreciosCuidados}");

            return sb.ToString();
        }
    }
}
