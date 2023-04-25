using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoweringC_
{
    internal class lowering_switch
    {
        public void RunSwitch()
        {
            var items = new[] { "shafi", "houd", "trumboo" };
            var random = new Random();
            var randomItem = items[random.Next(0,2)];
            switch (randomItem)
            {
                case "shafi":
                    Console.WriteLine($"Name was {randomItem}");
                    break;
                case "houd":
                    Console.WriteLine($"Name was {randomItem}");
                    break;
                case "trumboo":
                    Console.WriteLine($"Name was {randomItem}");
                    break;
            }
           
        }
    }
}
