using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero 0";
            Console.Write("Hola"); //printf("hola");
            Console.WriteLine(" Mundo."); //printf(" Munudo\n");

            Console.WriteLine("Ingrese nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");
            int edad = int.Parse( Console.ReadLine() );

            Console.WriteLine(nombre);

            Console.WriteLine("El nombre es {0} y su edad es: {1}", nombre, edad);

            Console.ReadKey(true); //getch / getche
        }
    }
}
