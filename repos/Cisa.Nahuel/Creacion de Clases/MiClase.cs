using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_de_Clases
{
    class MiClase
    {
        //Miembros de la clase: atributos y metodos

        //(*)atributos
        //propiedades
        //constructor
        //metodos
        //sobrecargas

        //Estaticos(de clase) se accede como MiClase.atributo y NO estaticos(de instancia) se accede con nombredelobjeto.miembro/atributo -------- this.atributo

        #region No staticos
        
        public float reales;

        public void MetodoNoEstatico()
        {
            Console.WriteLine("No estatico {0} - estatico {1}", this.reales, MiClase.entero);
        }
        
        #endregion

        #region Estaticos

        private static string cadena;
        public static int entero;

        public static void MetodoUno()
        {
            //implementacion
            string algo;

            algo = "hola";

            Console.WriteLine(algo);

        }

        public static int MetodoDos(string paramUno)
        {
            int valor = int.Parse(paramUno);

            return valor;
        }

        #endregion

        public static void MetodoConParametroObj(MiClase obj)
        {
            obj.reales = 99;
            obj.MetodoNoEstatico();

            MiClase otroOjb = new MiClase();

            otroOjb.reales = 5;
        }


        #region Constructor de instancia(NO estaticos)

        public MiClase()
        {
            this.reales = 7;
        }

        #endregion



    }
}
