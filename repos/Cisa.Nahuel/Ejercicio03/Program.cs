using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 2";
            int cuadrado;
            int cubo;
            int num;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            while(num < 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                num = int.Parse(Console.ReadLine());
            }

            cuadrado =  (int) Math.Pow(num,2);
            cubo = (int)Math.Pow(num, 3);

            Console.WriteLine("El cuadrado del numero es: {0}, el cubo es {1}", cuadrado, cubo);

            Console.ReadKey(true);

        }
    }
}
