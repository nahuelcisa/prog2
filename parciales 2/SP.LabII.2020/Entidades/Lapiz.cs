using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


//Lapiz-> color:ConsoleColor(público); trazo:ETipoTrazo(enum {Fino, Grueso, Medio}; público); PreciosCuidados->true; 
//Reutilizar UtilesToString en ToString() (mostrar TODOS los valores).

namespace Entidades
{
    public class Lapiz : Utiles, ISerializa, IDeserializa
    {
        public enum ETipoTrazo { Fino, Grueso, Medio };
        public ConsoleColor color;
        public ETipoTrazo trazo;

        public override bool PreciosCuidados { get { return true; } }

        public Lapiz(ConsoleColor color, ETipoTrazo trazo, string marca, double precio) 
        : base(marca, precio)
        {
            this.color = color;
            this.trazo = trazo;
        }
        public Lapiz()
        : base() 
        {

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendFormat($"Trazo: {this.trazo}\n" +
                $"Color: { this.color.ToString()}\n" +
                $"Precio Cuidado: {this.PreciosCuidados}\n");

            return sb.ToString();
        }

        bool IDeserializa.Xml(out Lapiz l)
        {
            bool rta = true;

            try
            {
                using (XmlTextReader read = new XmlTextReader(this.Path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Lapiz));

                    l = (Lapiz)ser.Deserialize(read);

                }

            }
            catch (Exception)
            {
                rta = false;
                l = new Lapiz();
            }

            return rta;

        }

        public string Path
        {
            get
            {
                return Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop).ToString() + "\\Nahuel.Cisa.lapiz.xml";
            }
        }

        public bool Xml()
        {
            bool rta = true;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(this.Path, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Lapiz));

                    serializer.Serialize(writer, this);
                }

            }
            catch (Exception)
            {
                rta = false;

            }

            return rta;
        }


    }
}
