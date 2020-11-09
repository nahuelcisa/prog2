using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public ECilindrada cilindrada;


        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(marca, pais, modelo, precio)
        {
            this.cilindrada = cilindrada;
        }

        public static bool operator ==(Moto a, Moto b)
        {
            bool rta = false;

            if (a.cilindrada == b.cilindrada && (Vehiculo)a == (Vehiculo)b)
            {
                rta = true;
            }
            return rta;
        }


        public static bool operator !=(Moto a, Moto b)
        {

            return !(a == b);
        }


        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Moto)
            {
                rta = this == (Moto)obj;
            }

            return rta;
        }

        public static implicit operator Single(Moto a)
        {
            return a.precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)(Vehiculo)this);
            sb.AppendLine($"Cilindrada: {this.cilindrada.ToString()}\n");

            return sb.ToString();
        }
    }
}
