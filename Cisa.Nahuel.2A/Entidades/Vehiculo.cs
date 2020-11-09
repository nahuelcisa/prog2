using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                {
                    generadorDeVelocidades = new Random();
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);                    
                }
                return this.velocidadMaxima;
            }
        }

        public static explicit operator String(Vehiculo v)
        {
            return (string)Vehiculo.Mostrar(v);
        }


        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
        }

       
        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {           
            this.fabricante = fabri;
            this.precio = precio;
            this.modelo = modelo;
            this.velocidadMaxima = this.VelocidadMaxima;
        }

        public Vehiculo(string marca, EPais pais, string modelo, float precio):this(precio,modelo, new Fabricante(marca,pais))
        {          
        }

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{(String)v.fabricante}\n");
            sb.Append($"Modelo: {v.modelo}\n");
            sb.Append($"Velocidad maxima: {v.velocidadMaxima}\n");
            sb.Append($"Precio: {v.precio.ToString()}\n");

            return sb.ToString();

        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            bool rta = false;

            if (a.fabricante == b.fabricante)
            {
                rta = true;
            }
            return rta;
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {

            return !(a == b);
        }


    }
}
