using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            MiClase.entero = 2;
            MiClase.MetodoUno();
            MiClase.MetodoDos("32");

            

            MiClase obj = new MiClase();

            obj.reales = 5;
            obj.MetodoNoEstatico();

            MiClase.MetodoConParametroObj(obj);

            MiClase.entero = 8;

            MiClase obj2 = new MiClase();

            obj2.reales = 9;
            obj2.MetodoNoEstatico();


            Console.ReadLine();
        }
    }
}
