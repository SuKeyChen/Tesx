using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;

namespace WvsAppLib.Common.Login
{
    public sealed class LoginServer : Server
    {

        #region Local Variables
        public int MaxCharacterCount { get; private set; }
        #endregion

        #region Singleton Pattern Implementation
        private static volatile LoginServer instance;
        private static object syncRoot = new Object();

        private LoginServer() { }

        /// <summary>
        /// Gets an instance of the Login Server.
        /// </summary>
        public static LoginServer Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LoginServer();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region Methods
        public void Configure() { }
        /// <summary>
        /// Start Login Server Instance.
        /// </summary>
        public void Start()
        {
            //Socket.BeginAccept(new AsyncCallback(null), );
        }
        /// <summary>
        /// Event Handler for incoming packets received from the socket.
        /// </summary>
        /// <param name="iPacket">Incoming Packet</param>
        public void OnPacket(InPacket iPacket)
        {
            if (iPacket.Decode2() == (short) InPacketHeader.SelectWorldResult)
            { }
        }
        #endregion
    }
}
