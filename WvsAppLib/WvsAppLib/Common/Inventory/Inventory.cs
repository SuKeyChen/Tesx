using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WvsAppLib.Common.Inventory
{
    public sealed class Inventory
    {
        public List<Item> Items { get; set; }

        public override string ToString()
        {
            if (Items == null)
                return "Null reference instance.";

            return JsonConvert.SerializeObject(this);
        }
    }
}
