using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;

namespace WvsAppLib.Interfaces
{
    interface ILoginHandler
    {
        void OnAccountInfo(ref InPacket iPacket);
        void OnChangeSPW(ref InPacket iPacket);
        void OnCharacterList(ref InPacket iPacket);
        void OnCheckPassword(ref InPacket iPacket);
        void OnCheckSPWExist(ref InPacket iPacket);
        void OnCheckSPWOnCreateNewCharacter(ref InPacket iPacket);
        void OnCheckSPW(ref InPacket iPacket);
        void OnSetSPW(ref InPacket iPacket);
        void OnWorldInfoForShining(ref InPacket iPacket);
        void OnCopyCharacterToTest(ref InPacket iPacket);
        void OnCreateNewCharacter(ref InPacket iPacket);
        void OnDeleteCharacter(ref InPacket iPacket);
        void OnDeleteCharStep(ref InPacket iPacket);
        void OnRenameCharacter(ref InPacket iPacket);
        void OnReservedDeleteCharacter(ref InPacket iPacket);
        void OnReservedDeleteCharacterCancel(ref InPacket iPacket);
        void OnSelectCharacter(ref InPacket iPacket);
        void OnSelectWorld(ref InPacket iPacket);
    }
}
