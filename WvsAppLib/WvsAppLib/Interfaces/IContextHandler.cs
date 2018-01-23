using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;

namespace WvsAppLib.Interfaces
{
    interface IContextHandler
    {
        void OnInventoryOperation(ref InPacket iPacket);
        void On(ref InPacket iPacket);
    }
}
