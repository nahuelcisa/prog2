using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int fecha = 2000;
            int inicio;
            int fin;

            Console.WriteLine("Ingrese anio de inicio:");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese anio de fin:");
            fin = int.Parse(Console.ReadLine());

            do
            {

                fecha = inicio;

                if (fecha % 4 != 0 || (fecha % 100 == 0 & fecha % 400 != 0))
                {}
                else
                {
                    Console.WriteLine("{0} Es bisiesto entre los anios colocados.",fecha);
                }

                inicio++;

            } while (inicio <= fin);


            Console.ReadKey(true);
        }
    }
}
