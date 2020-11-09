using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int l = 1, n;
            Boolean r = true;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while (r)
            {
                for(int i = 2; i <= l; i++)
                {
                    if((2*(i*i)) == ((l * l) + l))
                    {
                        if(i > n)
                        {
                            r = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Entre el 1 y {0} el centro numerico es {1}", l,i);
                        }
                    }
                }
                l++;
            }
            Console.ReadKey(true);
        }
    }
}
