using System;

namespace Entidades
{
#pragma warning disable CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Cosa
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0659 // El tipo reemplaza a Object.Equals(object o), pero no reemplaza a Object.GetHashCode()
    {

        #region Atributos

        private int entero;
        private string cadena;
        private DateTime fecha;
        #endregion




        #region Constructores

        public Cosa()
        {
            this.entero = 0;
            this.cadena = "";
            this.fecha = DateTime.Now;
        }

        public Cosa(string valor) : this()
        {
            //this.entero = 0;
            this.cadena = valor;
            //this.fecha = DateTime.Now;
        }

        public Cosa(string valorString, int valorInt) : this(valorString)
        {
            this.entero = valorInt;
            // this.cadena = valorString;
            // this.fecha = DateTime.Now;
        }


        #endregion


        #region Metodos


        public void Mostrar()
        {
            Console.WriteLine("Entero: {0}\nCadena: {1}\nFecha: {2}\n", this.entero, this.cadena, this.fecha);
        }

        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }

        public void EstablecerValor(string valor)
        {
            this.cadena = valor;
        }

        public void EstablecerValor(DateTime valor)
        {
            this.fecha = valor;
        }

        public override bool Equals(object obj)
        {
            return obj is Cosa cosa &&
                   entero == cosa.entero &&
                   cadena == cosa.cadena &&
                   fecha == cosa.fecha;
        }

        #endregion

        public static bool operator ==(Cosa c, OtraCosa oc)
        {
            bool rta = false;

            if (c.entero == oc.entero && c.cadena == oc.cadena)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Cosa c, OtraCosa oc)
        {
            //bool rta = ;

            ////if (c.entero != oc.entero || c.cadena != oc.cadena)
            ////{
            ////    rta = true;
            ////}

            //return rta; 

            //if(c == oc)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

            return !(c == oc);

        }

        public static bool operator ==(Cosa c, Cosa c1)
        {
            if (c.entero == c1.entero)
                return true;

            return false;
        }

        public static bool operator !=(Cosa c, Cosa c1)
        {
            return !(c == c1);
        }

        public static bool operator ==(Cosa c, int n)
        {
            if (c.entero == n)
                return true;

            return false;
        }

        public static bool operator !=(Cosa c, int n)
        {
            return !(c == n);
        }

        public static bool operator ==(int n, Cosa c)
        {
            if (c.entero == n)
                return true;

            return false;
        }

        public static bool operator !=(int n, Cosa c)
        {
            return !(c == n);
        }

        public static Cosa operator +(Cosa c, Cosa c1)
        {
            int rta = c.entero + c1.entero;

            Cosa crta = new Cosa();

            crta.entero = rta;

            return crta;
        }

    }
}
