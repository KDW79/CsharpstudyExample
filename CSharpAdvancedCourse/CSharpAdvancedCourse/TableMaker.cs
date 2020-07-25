using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvancedCourse
{
    class TableMaker
    {
       public void MakeTables()
        {
            DoWork1();
            DoWork2();
            //Thread t1 = new Thread(new ThreadStart(DoWork1));
            //t1.Start();
            //Thread t2 = new Thread(new ThreadStart(DoWork2));
            //t2.Start();
        }

        private void DoWork1()
        {
            int count = 0;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            while (count < 10) // 100
            {
                // make table
                // ...
                Thread.Sleep(1000);

                //if (count == 5) Debugger.Break();
                count++;
                Console.WriteLine($"{threadId} : {count}");
            
            }
        }

        private void DoWork2()
        {
            int count = 0;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            while (count < 10) // 100
            {
                // make table
                // ...
                Thread.Sleep(1000);

                //if (count == 5) Debugger.Break();
                count++;
                Console.WriteLine($"{threadId} : {count}");

            }
        }
    }
}
