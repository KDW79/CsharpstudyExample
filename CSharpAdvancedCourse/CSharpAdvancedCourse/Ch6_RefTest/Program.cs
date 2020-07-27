using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_RefTest
{

    class MyData
    {
        public int Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Program().ReferenceRun();
        }

        unsafe void ReferenceRun()
        {
            for (int i = 0; i < 100000; i++)
            {
                var obj = new MyData();
            }

            var data = new MyData();
            data.Value = 55;

            fixed (int* p = &data.Value)
            {
                Console.WriteLine("Address: {0}", (int)p);
            }

            for (int i = 0; i < 100000; i++)
            {
                var obj = new MyData();
            }

            GC.Collect();

            fixed (int* p = &data.Value)
            {
                Console.WriteLine("Address: {0}", (int)p);
            }

        }
    }
}
