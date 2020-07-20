using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ch4_StaticTest
{
    static class MyCalc
    {
        //static method
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var n in numbers)
            {
                sum += n;
            }
            return sum;
        }

        public static double Avg(int[] numbers)
        {
            double avg = Sum(numbers) / numbers.Count();
            return avg;
        }

        private static int counter;

        static MyCalc()
        {
            counter = 0;
            // ...
        }

        private static object objLock = new object();

        public static int NextCount
        {
            get
            {
                //lock (objLock)
                //{
                //    counter++;
                //    return counter;
                //}
                return Interlocked.Increment(ref counter);
            }
        }

    }
}
