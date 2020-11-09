using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
#pragma warning disable CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
#pragma warning disable CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
    public class Numero
#pragma warning restore CS0661 // El tipo define operator == or operator !=, pero no reemplaza a Object.GetHashCode()
#pragma warning restore CS0660 // El tipo define operator == or operator !=, pero no reemplaza a override Object.Equals(object o)
    {
        //se cambia public por private
        private double valor;

        //se cambia public por private
        private Numero(double valor)
        {
            this.valor = valor;
        }

        #region sobrecarga de operadores

        #region igualdad

        public static bool operator ==(Numero n1, Numero n2) 
        {
            //se cambia n1.valor por n1 --> se reutiliza la sobrecarga (Numero, double)
            return n1 == n2.valor;
        }

        public static bool operator !=(Numero n1, Numero n2)
        {
            return !(n1 == n2);
        }

        public static bool operator ==(Numero n1, Double n2)
        {
            return n1.valor == n2;
        }

        public static bool operator !=(Numero n1, Double n2)
        {
            return !(n1 == n2);
        }

        #endregion

        #region adición y sustracción

        public static Numero operator +(Numero n1, Numero n2)
        {
            //se cambia n2.valor por (double)n2 --> se reutiliza conversión explícita 
            double suma = n1.valor + (double)n2;

            Numero rta = new Numero(suma);

            return rta;
        }

        public static Numero operator -(Numero n1, Numero n2)
        {
            //se cambia n2.valor por (double)n2 --> se reutiliza conversión explícita 
            double resta = n1.valor - (double)n2;

            Numero rta = new Numero(resta);

            return rta;
        }

        #endregion

        #region incremento - decremento

        public static Numero operator ++(Numero n1)
        {
            //acá también se podría reutilizar la conversión explícita
            double incremento = n1.valor++;

            Numero rta = new Numero(incremento);

            return rta;
        }

        public static Numero operator --(Numero n1)
        {
            //acá también se podría reutilizar la conversión explícita
            double decremento = n1.valor--;

            Numero rta = new Numero(decremento);

            return rta;
        }

        #endregion

        #region implícito - explícito

        public static implicit operator Numero(Double valor)
        {
            return new Numero(valor);
        }

        public static explicit operator Double(Numero n1)
        {
            return n1.valor;
        }

        #endregion

        #endregion

    }
}
