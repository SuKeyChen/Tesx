using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Networking
{
    public sealed class OutPacket
    {
        int header;
        byte[] buffer;
        bool isLoopback;

        #region Constructors
        public OutPacket(int header) { this.header = header; }
        public OutPacket(int header, byte[] buffer) { this.header = header; this.buffer = buffer; }
        #endregion

        #region Encapsulations
        public int Header { get { return this.header; } private set { this.header = value; } }
        public byte[] Buffer { get { return this.buffer; } private set { this.buffer = value; } }
        #endregion

        #region Methods
        protected internal void Encode1(byte b)
        { }
        protected internal void Encode1(int i)
        { }
        protected internal void Encode1(char c)
        { }

        protected internal void Encode2(byte b)
        { }
        protected internal void Encode2(int i)
        { }
        protected internal void Encode2(char c)
        { }
        protected internal void Encode2(string s)
        { }

        protected internal void Encode4(byte b)
        { }
        protected internal void Encode4(int i)
        { }
        protected internal void Encode4(char c)
        { }
        protected internal void Encode4(string s)
        { }
        protected internal void Encode4(long l)
        { }

        protected internal void Encode8(int i)
        { }
        protected internal void Encode8(char c)
        { }
        protected internal void Encode8(string s)
        { }
        protected internal void Encode8(long l)
        { }

        protected internal void EncodeBuffer(int i, int size)
        { }
        protected internal void EncodeBuffer(string s, int size)
        { }
        protected internal void EncodeBuffer(byte[] b, int size)
        { }

        protected internal void EncodeString(string s)
        { }
        #endregion
    }
}
