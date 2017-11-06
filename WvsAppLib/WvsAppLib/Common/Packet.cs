using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common
{
    public abstract class Packet
    {
        private bool loopback;
        private byte state;
        private byte[] buffer;
        private uint length, dataLength, offset;

        public bool IsLoopback { get; protected set; }
        public byte State { get; protected set; }
        public byte[] Buffer { get; protected set; }
        public int Length { get; protected set; }
        public int DataLength { get; protected set; }
        public int Offset { get; protected set; }

        protected void EnlargeBuffer(int size)
        {
            byte[] newBuffer = new byte[Length + size];
            System.Buffer.BlockCopy(Buffer, Offset, newBuffer, 0, size);
            Buffer = newBuffer;
            Length = Buffer.Length;
        }
        public void Dump() { }
        public void DisplayArray(string name)
        {
            // Get the array element width; format the formatting string.
            int elemWidth = System.Buffer.ByteLength(Buffer) / Buffer.Length;
            string format = String.Format(" {{0:X{0}}}", 2 * elemWidth);

            // Display the array elements from right to left.
            Console.Write("{0,5}:", name);
            for (int loopX = Buffer.Length - 1; loopX >= 0; loopX--)
                Console.Write(format, Buffer.GetValue(loopX));
            Console.WriteLine();
        }
    }

    /* 3241 */
    //struct CInPacket
    //{
    //    int m_bLoopback;
    //    int m_nState;
    //    ZArray<unsigned char> m_aRecvBuff;
    //    unsigned int m_uLength;
    //    unsigned __int16 m_uRawSeq;
    //    unsigned int m_uDataLen;
    //    unsigned int m_uOffset;
    //};
    public sealed class InPacket : Packet
    {
        public InPacket (short header, byte[] buffer)
        {
            Buffer = buffer;
        }

        public char Decode1()
        {
            char c = BitConverter.ToChar(Buffer, Offset);
            Offset += 1;

            return c;
        }
        public short Decode2()
        {
            short s = BitConverter.ToInt16(Buffer, Offset);
            Offset += 2;

            return s;
        }
        public int Decode4()
        {
            int i = BitConverter.ToInt32(Buffer, Offset);
            Offset += 4;

            return i;
        }
        public long Decode8()
        {
            long l = BitConverter.ToInt64(Buffer, Offset);
            Offset += 8;

            return l;
        }
        public byte[] DecodeBuffer(int size)
        {
            byte[] buffer = new byte[size];
            System.Buffer.BlockCopy(Buffer, Offset, buffer, 0, size);
            Offset += size;

            return buffer;
        }
        public string DecodeString()
        {
            int length = Decode2();
            string text = Encoding.UTF8.GetString(DecodeBuffer(length));
            Offset += length;

            return text;
        }
    }

    /* 4366 */
    //struct COutPacket
    //{
    //    int m_bLoopback;
    //    ZArray<unsigned char> m_aSendBuff;
    //    unsigned int m_uOffset;
    //    int m_bTypeHeader1Byte;
    //    int m_bIsEncryptedByShanda;
    //};
    public sealed class OutPacket : Packet
    {
        private bool typeHeader1Byte;
        private bool isEncryptedByShanda;

        #region Constructors
        public OutPacket(short header)
        {
            Buffer = new byte[4];
            Offset = 0;
            Length = Buffer.Length;
        }

        #endregion

        #region Methods
        public void Encode1(char c)
        {
            EnlargeBuffer(1);
            System.Buffer.BlockCopy(new byte[] { (byte) c }, 0, Buffer, Offset, 1);
            Offset += 1;
        }
        public void Encode2(short s)
        {
            EnlargeBuffer(2);
            System.Buffer.BlockCopy(new byte[] { (byte) s, (byte) (s >> 8) }, 0, Buffer, Offset, 2);
            Offset += 2;
        }
        public void Encode4(int i)
        {
            EnlargeBuffer(4);
            System.Buffer.BlockCopy(new byte[] { (byte) i, (byte) (i >> 8), (byte) (i >> 16), (byte) (i >> 24)}, 0, Buffer, Offset, 4);
            Offset += 4;
        }
        public void Encode8(long l)
        {
            EnlargeBuffer(8);
            System.Buffer.BlockCopy(new byte[] { (byte) l, (byte) (l >> 8), (byte) (l >> 16), (byte) (l >> 24), (byte) (l >> 32), (byte) (l >> 40), (byte) (l >> 48), (byte) (l >> 56) }, 0, Buffer, Offset, 8);
            Offset += 8;
        }
        public void EncodeBuffer(byte[] buffer, int size)
        {
            EnlargeBuffer(size);
            System.Buffer.BlockCopy(buffer, 0, Buffer, Offset, size);
            Offset += size;
        }
        public void EncodeString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            Encode2((short)buffer.Length);
            EncodeBuffer(buffer, buffer.Length);
        }
        #endregion
    }
}
