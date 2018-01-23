using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WvsAppLib.Common.Inventory
{
    public enum ItemCategory
    {
        Equipment,
        Consumable,
        Etc,
        Setup,
        Cash
    }

    public enum Gender
    {
        Male = 0x0,
        Female = 0x1,
        Unisex = 0x2
    };

    public static class ItemInfo
    {
        public static bool IsFaceItem(int id) { return true; }
        public static Gender GetGender(int id) { return (Gender)(id % 1000); }
        public static bool IsCashItem(int id) { return true; }
    }

    public class ItemStat
    {
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; }
        public int Luk { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Mp { get; set; }
        public int MaxMp { get; set; }
        public int LevelReduction { get; set; }
        public int AdditionalOptionAllStat { get; set; }
    }
}
