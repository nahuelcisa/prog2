using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    //Clase CLiente Listo
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;


        public Cliente()
        {
            this._aliasParaIncognito = "Sin alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente):this()
        {
            this._tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            Random rand = new Random();

            this._aliasParaIncognito = rand.Next(1000, 9999) + this._tipoDeCliente.ToString();
        }        

        public string GetAlias()
        {
            string rta = "ERROR.";
           if(this._aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
                rta =  this._aliasParaIncognito;
            }
            return rta;
        }

        
        private string RetornarDatos()
        {
            return RetornarDatos(this);            
        }

        public string RetornarDatos(Cliente unCliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(unCliente._nombre);
            sb.Append("Tipo: ");
            sb.AppendLine(unCliente._tipoDeCliente.ToString());
            sb.Append("Alias: ");
            sb.AppendLine(unCliente._aliasParaIncognito);

            return sb.ToString();
        }
    }



    public class CuentaOffShore
    {
        private Cliente _dueño;
        private int _numeroCuenta;
        private double _saldo;


        public CuentaOffShore(Cliente dueño, int numero, double saldoInicial)
        {
            this._dueño = dueño;
            this._numeroCuenta = numero;
            this._saldo = saldoInicial;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial):this(new Cliente(tipo,nombre),numero,saldoInicial)
        {

        }

        public Cliente Dueño
        {
            get { return this._dueño; }
        }

        public double Saldo
        {
            get { return this._saldo; }
            set { this._saldo = value; }
        }


        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool rta = false;

            if(cos1._numeroCuenta == cos2._numeroCuenta && cos1._dueño.GetAlias() == cos2._dueño.GetAlias())
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1 == cos2);
        }


        public static explicit operator int(CuentaOffShore cos)
        {
            return (int)cos._numeroCuenta;
        }




    }


    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listaCuentas;
        private eParaisosFiscales _lugar;
        public int cantidadDeCuentas;
        public DateTime fechaInicioActividades;

 
        private ParaisoFiscal()
        {
            this._listaCuentas = new List<CuentaOffShore>();
            this.cantidadDeCuentas = 0;
            this.fechaInicioActividades = DateTime.Now;         
        }


        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            this._lugar = lugar;
        }

        public void MostrarParaiso()
        {
          
                StringBuilder sb = new StringBuilder();

                sb.Append("Fecha de Inicio: ");
                sb.AppendLine(this.fechaInicioActividades.ToString());
                sb.Append("Locacion: ");
                sb.AppendLine(this._lugar.ToString());
                sb.Append("Cantidad de 'cuentitas': ");
                sb.AppendLine(this.cantidadDeCuentas.ToString());
                sb.AppendLine("******************Listado de cuentas offshores******************");

                foreach (var item in this._listaCuentas)
                {
                    sb.Append(item.Dueño.RetornarDatos(item.Dueño));
                    sb.Append("Numero de la cuenta:");
                    sb.AppendLine(((int)item).ToString());
                    sb.Append("Saldo: ");
                    sb.AppendLine(item.Saldo.ToString());
                    sb.AppendLine("");
                }
                Console.WriteLine(sb.ToString());
        
        }

        public  static implicit  operator ParaisoFiscal(eParaisosFiscales epf)
        {
            return new ParaisoFiscal(epf);
        }


        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool rta = false;

                foreach (CuentaOffShore item in pf._listaCuentas)
                {
                    if (item == cos)
                    {
                        rta = true;
                        break;
                    }

                }


            return rta;
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }


        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {

            if (pf == cos)
            {
               
                pf._listaCuentas.Remove(cos);
                pf.cantidadDeCuentas--;
                Console.WriteLine("Se quito la cuenta al paraiso..");
            }
            else
            {
                Console.WriteLine("La cuenta no existe en el paraiso...");
            }

                return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            

            if (! (pf == cos))
            {
                pf._listaCuentas.Add(cos);
                pf.cantidadDeCuentas++;
                Console.WriteLine("Se agrego la cuenta al paraiso..");
            }

            foreach (CuentaOffShore item in pf._listaCuentas)
            {
                if (item == cos)
                {
                    item.Saldo += cos.Saldo;
                    Console.WriteLine("Se actualizo el saldo de la cuenta...");                 
                }

            }


            return pf;
        }

    }
}
