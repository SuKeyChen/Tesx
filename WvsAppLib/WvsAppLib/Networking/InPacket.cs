using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Networking
{
    public sealed class InPacket
    {
        int header;
        byte[] buffer;
        bool isLoopback;

        #region Constructors
        public InPacket(int header, byte[] buffer) { this.header = header; this.buffer = buffer; }
        #endregion

        #region Encapsulations
        public int Header { get { return this.header; } private set { this.header = value; } }
        public byte[] Buffer { get { return this.buffer; } private set { this.buffer = value; } }
        #endregion

        #region Methods
        protected internal void Decode1() { }
        protected internal void Decode2() { }
        protected internal void Decode4() { }
        protected internal void Decode8() { }
        protected internal void DecodeBuffer() { }
        protected internal void DecodeString() { }
        #endregion
    }
}
