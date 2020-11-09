using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        public ETipo tipo;


        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            : base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool rta = false;

            if (a.tipo == b.tipo && (Vehiculo)a == (Vehiculo)b)
            {
                rta = true;
            }
            return rta;
        }

       
        public static bool operator !=(Auto a, Auto b)
        {

            return !(a == b);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Auto)
            {
                rta = this == (Auto)obj;
            }

            return rta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((String)(Vehiculo)this);
            sb.AppendLine($"Tipo: {this.tipo.ToString()}\n");

            return sb.ToString();
        }


    }
}
