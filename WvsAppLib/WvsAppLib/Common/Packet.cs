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

        public bool IsLoopback { get; private set; }
        public byte State { get; private set; }
        public byte[] Buffer { get; private set; }
        public uint Length { get; private set; }
        public uint DataLength { get; private set; }
        public uint Offset { get; private set; }

        public void Dump() { }
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
        public char Decode1()
        {
            return 'c';
        }
        public short Decode2()
        {
            return 10;
        }
        public int Decode4()
        {
            return 0;
        }
        public long Decode8()
        {
            return 0;
        }
        public byte[] DecodeBuffer(int size)
        {
            return null;
        }
        public string DecodeString()
        {
            return string.Empty;
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

        public void Encode1(char c)
        {
        }
        public void Encode2(short sInteger)
        {
        }
        public void Encode4(int integer)
        {
        }
        public void Encode8(long sInteger)
        {
        }
        public void EncodeBuffer(byte[] buffer, int size)
        {
        }
        public void EncodeString(string text)
        {
        }
    }
}
