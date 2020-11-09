using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion
            int cantidad = 5;
            int[] vec = new int[cantidad];
            vec[0] = 1;

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine(vec[i]);
            } 
            Console.ReadLine();
        }
    }
}
