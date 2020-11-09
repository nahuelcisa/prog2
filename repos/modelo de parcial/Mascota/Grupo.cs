using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static EtipoManada tipo;

        public static EtipoManada Tipo
        {           
            set { Grupo.tipo = value; }
        }

        static Grupo()
        {
            Grupo.Tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Grupo: {g.nombre} - tipo: {Grupo.tipo}\n");
            sb.AppendFormat($"Integrantes: ({g.manada.Count})\n");
            foreach (Mascota item in g.manada)
            {
                sb.AppendFormat($"{item.ToString()}\n");
            }
            return sb.ToString();
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool rta = false;
            
            if(g.manada.Contains(m) == true)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if( g != m)
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine($"Ya esta {m.ToString()} en el grupo");
            }
            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g.manada.Remove(m);
            }
            else
            {
                Console.WriteLine($"No esta {m.ToString()} en el grupo");
            }
            return g;
        }
    }
}
