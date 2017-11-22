using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;

namespace WvsAppLib.Wvs
{
    public enum World
    {
        Scania = 0,
        Bera = 1,
        Broa = 2,
        Windia,
        Khaini = 4,
        Bellocan = 5,
        Mardia = 6,
        Kradia = 7,
        Yellonde = 8,
        Demethos = 9,
        Galicia = 10,
        ElNido = 11,
        Zenith = 12,
        Arcania = 13,
        Chaos = 14,
        Nova = 15,
        Renegades = 16,
        Enosis = 29,
        Luna = 30,
        Elysium = 31,
        Red = 43,
        Aurora = 44,
        Reboot = 45,
        Reboot2 = 46,
        Arcane = 50,
        Tespia = 100 //GMS Exclusive
    }

    public sealed class GameServer : Server
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string RecommendationMessage { get; private set; }
        public int ExpRate { get; private set; }
        public int DropRate { get; private set; }
        public Dictionary<JobRace, bool> EnabledJobRaces { get; set; }

        public GameServer(World world, short port, string msg, int exp, int drop, Dictionary<JobRace, bool> enabledJobRaces) : base(port)
        {
            Id = (int)world;
            Name = world.ToString();
            RecommendationMessage = msg;
            ExpRate = exp;
            DropRate = drop;
            EnabledJobRaces = enabledJobRaces;
        }

        public void Start() { }
        public void Stop() { }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
