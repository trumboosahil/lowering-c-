using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoweringC_
{
    public class lowering_loop
    {
        public void RunLoops()
        {
            var items = new[] { "shafi", "houd", "trumboo" };
            foreach (var item in items)
            {
                Console.Out.WriteLine(item);
            }

            for (int i = 0; i < items.Length; i++)
            {
                Console.Out.WriteLine(items[i]);
            }
            int i1 = 0;
            while (i1 < items.Length)
            {
                Console.Out.WriteLine(items[i1]);
                i1++;
            }
        }
    }
}
