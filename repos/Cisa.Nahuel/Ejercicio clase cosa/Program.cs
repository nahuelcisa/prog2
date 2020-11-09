using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Ejercicio_clase_cosa
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Cosa cosa1 = new Cosa();
            cosa1.Mostrar();

            Cosa cosa2 = new Cosa("Me llamo nahuel");
            cosa2.Mostrar();

            Cosa cosa3 = new Cosa("Me llamo nahuel",2);
            cosa3.Mostrar();
            */

            Cosa c1 = new Cosa();

            OtraCosa c3 = new OtraCosa();

            Cosa c2 = new Cosa("hola",2);

            if (c1 == c2)
            {

            }

            c3.entero = 1;

            if (c2 == c3)
            {

            }



            Console.ReadKey(true);
           

        }
    }
}
