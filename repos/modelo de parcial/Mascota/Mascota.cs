using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;


        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Raza
        {
            get { return this.raza; }
        }

        #endregion

        #region Metodos

        #region Constructor

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        #endregion

        abstract protected string Ficha();

        virtual protected string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {this.nombre} - Raza: {this.raza}");

            return sb.ToString();
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool rta = false;

            if (String.Compare(m1.DatosCompletos(), m2.DatosCompletos()) == 0)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return (! (m1 == m2) );
        }

        #endregion
    }   
}
