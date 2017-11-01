using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common.Character
{
    public class CharacterData
    {
        private int level;
        private CharacterStat characterStat;

        #region Methods
        public void Encode(out OutPacket outPacket) { outPacket = null; }
        public void Decode() { }
        #endregion
    }
}
