using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;

namespace WvsAppLib.Wvs
{
    class World
    {
        protected readonly short Port = 8000;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string RecommendationMessage { get; private set; }
        public int ExpRate { get; private set; }
        public int DropRate { get; private set; }
        
        public World(int id, short port, string name, string msg, int exp, int drop)
        {
            Id = id;
            Port = port;
            RecommendationMessage = msg;
            ExpRate = exp;
            DropRate = drop;
        }
    }
}
