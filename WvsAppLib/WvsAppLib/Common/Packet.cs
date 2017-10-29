using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common
{
    abstract class Packet
    {
        private bool loopback;
        private byte state;
        private byte[] buffer;
        private uint length, dataLength, offset;
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
    class InPacket : Packet
    {
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
    class OutPacket : Packet
    {
        private bool typeHeader1Byte;
        private bool isEncryptedByShanda;
    }
}
