using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvancedCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //new TableMaker().MakeTables();

            var tm = new TableMaker();

            Thread[] t = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                t[i] = new Thread(new ThreadStart(tm.DoWork));
                t[i].Start();

            }

            for (int i = 0; i < 10; i++)
            {
                t[i].Join();
            }

            int total = tm.TotalCount;
            Console.WriteLine($"Total: {total}");
        }
    }
}
