using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WvsAppLib.Common;
using WvsAppLib.Common.Inventory;
using WvsAppLib.Wvs;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OutPacket Encoded");
            OutPacket outPacket = new OutPacket(0x12);
            outPacket.Encode1('c');
            outPacket.Encode8(99999999999);
            outPacket.EncodeString("Hello World!");
            outPacket.Encode2(123);
            outPacket.Encode4(1020);
            outPacket.Encode1('g');
            outPacket.Encode4(900);
            outPacket.Encode1('?');
            outPacket.DisplayArray("OutPacket Buffer");

            Console.WriteLine("\nInPacket Decoded");
            InPacket inPacket = new InPacket(0x12, outPacket.Buffer);
            inPacket.DisplayArray("InPacket Buffer");
            Console.WriteLine("Decode1 - {0}", inPacket.Decode1());
            Console.WriteLine("Decode8 - {0:N}", inPacket.Decode8());
            Console.WriteLine("DecodeString - {0}", inPacket.DecodeString());
            Console.WriteLine("Decode2 - {0}", inPacket.Decode2());
            Console.WriteLine("Decode4 - {0}", inPacket.Decode4());
            Console.WriteLine("Decode1 - {0}", inPacket.Decode1());
            Console.WriteLine("Decode4 - {0}", inPacket.Decode4());
            Console.WriteLine("Decode1 - {0}", inPacket.Decode1());

            Dictionary<JobRace, bool> d = new Dictionary<JobRace, bool>();
            d.Add(JobRace.Resistance, true);
            d.Add(JobRace.Explorer, true);

            GameServer Tespia = new GameServer(World.Tespia, 8080, "", 1, 1, d);
            Console.WriteLine("\nHosting Game Server [{0}] on Port {1}...\nServer Info:\nId: {2}\nMsg: {3}\n", Tespia.Name, Tespia.Port, Tespia.Id, Tespia.RecommendationMessage);

            Inventory inventory = new Inventory();
            inventory.Items = new List<Item> { new Item { Id = 123 }, new Item { Id = 10000001 }, new Item { Id = 14200000 } };
            Console.WriteLine("\nInventory Dump:\n{0}", inventory.ToString());

            Console.WriteLine("Dumping Game Server:\n{0}", Tespia.ToString());

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
