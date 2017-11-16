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
        public short Port { get; private set; }
        public Socket Socket { get; private set; }

        public Server() { }
    }
}
