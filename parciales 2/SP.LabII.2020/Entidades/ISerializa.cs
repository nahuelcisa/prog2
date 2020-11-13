using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#.-ISerializa -> Xml() : bool
//              -> Path{ get; } : string

namespace Entidades
{
    interface ISerializa
    {
        
        string Path { get; }

        bool Xml();
    }
}
