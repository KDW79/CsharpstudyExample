using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2_IndexerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCache myCache = new MyCache();
            myCache.Add("ItemId", "1100");
            string dbg = myCache.Get("Debug");
            myCache.Set("Debug", "false");

            string db = myCache["Debug"];
            myCache["Debug"] = "false";
        }
    }
}
