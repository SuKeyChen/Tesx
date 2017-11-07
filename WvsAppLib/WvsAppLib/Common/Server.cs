using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common
{
    public abstract class Server
    {
        public readonly short Port = 8484;

        public Socket Socket { get; private set; }
    }
}
