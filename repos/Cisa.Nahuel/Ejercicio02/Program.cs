using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 1";

            int numero;
            int max = 0;
            int min = 0;
            float promedio;
            int acumulador = 0;
            int flag = 1;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("({0})Ingrese un numero: ",i+1);
                numero = int.Parse(Console.ReadLine());
                

                if (flag == 1)
                {
                    max = numero;
                    min = numero;
                    flag = 0;
                }

                if (numero > max)
                {
                    max = numero;
                }

                if(numero < min)
                {
                    min = numero;
                }

                acumulador = numero + acumulador;

            }

            promedio = acumulador / 5;

            Console.Write("El maximo numero es {0}, el minimo es {1} y el promedio es {2} ", max,min,promedio);
            Console.ReadKey();
        }
    }
}
