using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 3";

            int num;
            int divisores;
            

            Console.WriteLine("Ingrese un numero");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                divisores = 0;

                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        divisores++;
                }

                if(divisores == 2)
                {
                    Console.WriteLine("{0} Es un primo que esta entre el 0 y su numero.",i);
                }
            }

            Console.ReadKey(true);
        }
    }
}
