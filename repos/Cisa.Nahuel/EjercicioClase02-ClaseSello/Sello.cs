using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02_ClaseSello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {

            Sello.ArmarFormatoMensaje();

            return Sello.mensaje;

        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;

            Console.WriteLine(Sello.Imprimir());

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static string ArmarFormatoMensaje()
        {
            string retorno;
            string largo = "";

            for(int i = 0; i <= Sello.mensaje.Length; i++)
            {
                largo = largo + "*";
            }

            retorno = $"{largo}*\n*{Sello.mensaje}*\n*{largo}";

            Sello.mensaje = retorno;

            return retorno;


        }
    }
}
