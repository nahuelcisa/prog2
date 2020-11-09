using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        private int cantidad;
        private List<Vehiculo> vehiculos;

        Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }

        Concesionaria(int capacidad) : this()
        {
            this.cantidad = capacidad;
        }

        public double PrecioDeAutos
        {
            get
            {
                double acumulador = 0;

                foreach (Vehiculo item in vehiculos)
                {
                    if (item is Auto)
                    {
                        acumulador += (double)(Auto)item;
                    }
                }
                
                return acumulador;
            }
        }

        public double PrecioDeMotos
        {
            get
            {
                double acumulador = 0;

                foreach (Vehiculo item in vehiculos)
                {
                    if (item is Moto)
                    {
                        acumulador += (Moto)item;
                    }
                }

                return acumulador;
            }
        }

        public double PrecioTotal
        {
            get
            {
                double total;
                double precioMoto = this.PrecioDeMotos;
                double precioAuto = this.PrecioDeAutos;

                total = precioAuto + precioMoto;

                return total;
            }
        }


        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Cantidad: {0}\n", c.cantidad);
            sb.AppendFormat("Total de autos: {0}\n", c.PrecioDeAutos);
            sb.AppendFormat("Total de motos: {0}\n", c.PrecioDeMotos);
            sb.AppendFormat("Total: {0}\n", c.PrecioTotal);
            sb.AppendFormat("LISTADO DE VEHICULOS");
            sb.AppendLine("");
            foreach (Vehiculo v in c.vehiculos)
            {
                sb.AppendFormat($"{v.ToString()}\n");
            }

            return sb.ToString();
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }

        public static bool operator ==(Concesionaria c, Vehiculo v)
        {
            bool rta = false;

            //foreach (var a in c.vehiculos)
            //{
            //    if (a.Equals(v) == true)
            //    {
            //        rta = true;
            //    }
            //}
            if(c.vehiculos.Contains(v) == true)
            {
                rta = true;
            }

            
            return rta;
        }

        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            //if (c.cantidad > c.vehiculos.Count())
            //{
            //    if (c != v)
            //    {
            //        c.vehiculos.Add(v);
            //        c.cantidad++;
            //        //Console.WriteLine("El vehiculo ya esta en la concesionaria!!!!");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("No hay mas lugar en la concesionaria!!!!");
            //}

            return c;
            int cont = 0;
            foreach (Vehiculo x in c.vehiculos)
            {
                cont++;
            }

            if (c != v && !Object.Equals(c, v) && cont < c.cantidad)
            {
                c.vehiculos.Add(v);
                //Console.WriteLine("El vehiculo ya esta en la concesionaria!!!!");
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la concesionaria!!!!");
            }
            return c;
        }

        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double retorno = 0;

            switch (tipoVehiculo)
            {
                case EVehiculo.PrecioDeAutos:
                    retorno = this.PrecioDeAutos;
                    break;
                case EVehiculo.PrecioDeMotos:
                    retorno = this.PrecioDeMotos;
                    break;
                case EVehiculo.PrecioTotal:
                    retorno = this.PrecioTotal;
                    break;
                default:
                    break;
            }

            return retorno;
        }


    }
}
