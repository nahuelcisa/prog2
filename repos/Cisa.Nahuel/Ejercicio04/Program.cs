using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            long num = 1;
            int div = 0;
            int cont = 0;


            do
            {
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        div += i;
                    }
                }
                if (num == div)
                {
                    Console.WriteLine("{0} es el perfecto numero {1}", num,cont+1);
                    cont++;
                }
                num++;
                div = 0;
            }while (cont < 4);



            Console.ReadKey(true);
        }
    }
}
