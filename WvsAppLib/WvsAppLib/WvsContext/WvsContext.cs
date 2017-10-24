using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Helpers;
using WvsAppLib.Networking;

namespace WvsAppLib.WvsContext
{
    public sealed class WvsContext
    {
        #region Singleton Pattern Implementation
        private static volatile WvsContext instance;
        private static object syncRoot = new Object();

        private WvsContext() { }
        
        public static WvsContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new WvsContext();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region OnPacket Handler
        void OnPacket(InPacket inPacket)
        {
            if (inPacket.Header == (int)InPacketHeader.HANDSHAKE_REQUEST)
            {
            }
        }

        #region Handler Methods
        void InventoryOperation(InPacket inPacket)
        {
        }
        #endregion
        #endregion
    }
}
