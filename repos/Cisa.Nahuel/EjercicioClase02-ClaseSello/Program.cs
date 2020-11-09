using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase02_ClaseSello
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "asdfasdf";

            Console.WriteLine(Sello.Imprimir());//retorna string

            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());//retorna string

            Sello.mensaje = "nahuel cisa";
            
            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey(true);
        }
    }
}
