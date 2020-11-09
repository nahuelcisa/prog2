using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {

        private int edad;
        private bool esAlfa;

        #region Constructores

        public Perro(string nombre, string raza)
            : this(nombre, raza,0,false)
        {
         
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        #endregion

        #region Metodos

        protected override string Ficha()
        {

            StringBuilder sb = new StringBuilder();

            if (this.esAlfa)
            {
                sb.Append($"perro - {this.DatosCompletos()} - Alfa de la manada, edad :{this.edad}");
            }
            else
            {
                sb.Append($"perro - {this.DatosCompletos()}, edad :{this.edad}");
            }

            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            bool rta = false;

            if ((Mascota)p1 == (Mascota)p2 && (int)p1 == (int)p2)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator int(Perro p)
        {
            return (int)p.edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Perro)
            {
                rta = this == (Perro)obj;
            }

            return rta;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }

}
