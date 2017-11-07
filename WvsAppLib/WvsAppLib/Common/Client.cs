using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common
{
    public class Client
    {
        public int Id { get; private set; }
        public ClientSocket Socket { get; private set; }
        public User User { get; private set; }

        public Client() { }
    }
}
