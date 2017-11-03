using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common
{
    public sealed class ClientSocket
    {
        #region Singleton Pattern Implementation
        private static volatile ClientSocket instance;
        private static object syncRoot = new Object();

        private ClientSocket() { }

        public static ClientSocket Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ClientSocket();
                    }
                }

                return instance;
            }
        }

        public static ClientSocket GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new ClientSocket();
                }
            }

            return instance;
        }
        #endregion

        protected internal void SendPacket(OutPacket outPacket) { }

        protected internal void ProcessPacket(InPacket inPacket)
        {
        }
    }
}
