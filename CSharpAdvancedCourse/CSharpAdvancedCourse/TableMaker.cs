using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvancedCourse
{
    class TableMaker
    {
        private int totalCount = 0;
        public int TotalCount => totalCount;
        private object lockObj = new object();
       //public void MakeTables()
       // {
       //     //DoWork1();
       //     //DoWork2();
       //     Thread t1 = new Thread(new ThreadStart(DoWork));
       //     t1.Start();
       //     Thread t2 = new Thread(new ThreadStart(DoWork));
       //     t2.Start();
       // }

        public void DoWork()
        {
            int count = 0;
            int threadId = Thread.CurrentThread.ManagedThreadId;

            while (count < 10) // 100
            {
                // make table
                // ...
                Thread.Sleep(1);

                //if (count == 5)
                //    Debugger.Break();
                count++;
                lock(lockObj)
                {
                    totalCount++;

                }

            }
            Console.WriteLine($"{threadId} : {count}");
        }

        //private void DoWork2()
        //{
        //    int count = 0;
        //    int threadId = Thread.CurrentThread.ManagedThreadId;

        //    while (count < 10) // 100
        //    {
        //        // make table
        //        // ...
        //        Thread.Sleep(1000);

        //        if (count == 3) Debugger.Break();
        //        count++;
        //        Console.WriteLine($"{threadId} : {count}");

        //    }
        //}
    }
}
