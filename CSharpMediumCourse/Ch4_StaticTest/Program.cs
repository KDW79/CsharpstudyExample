using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticRun();
            Program.StaticRun();

            new Program().InstanceRun();

            var p = new Program();
            p.InstanceRun();

            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = MyCalc.Sum(nums);
            Console.WriteLine(sum);
            double avg = MyCalc.Avg(nums);
            Console.WriteLine(avg);

            int cnt = MyCalc.NextCount;
            Console.WriteLine(cnt); // 1
            cnt = MyCalc.NextCount;
            Console.WriteLine(cnt); // 2

            //MyCalc calcObj = new MyCalc();
            
          

        }

        static void StaticRun() { }
        void InstanceRun() { }
    }
}
