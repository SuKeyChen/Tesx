using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Helpers;
using WvsAppLib.Common;

namespace WvsAppLib.Wvs
{
    public sealed class Context
    {
        #region Singleton Pattern Implementation
        private static volatile Context instance;
        private static object syncRoot = new Object();

        private Context() { }
        
        public static Context Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Context();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region OnPacket Handler
        void OnPacket(InPacket inPacket)
        {
        }

        #region Handler Methods
        void InventoryOperation(InPacket inPacket)
        {
        }
        #endregion
        #endregion
    }
}
