using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#.-IDeserializa -> Xml(out Lapiz) : bool

namespace Entidades
{
    public interface IDeserializa
    {       
        bool Xml(out Lapiz l);

    }
}
