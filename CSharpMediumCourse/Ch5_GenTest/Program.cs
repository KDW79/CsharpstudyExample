using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_GenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var iCalc = new Calculator<int>();
            var x = iCalc.Add(1, 2);
            Console.WriteLine(x);

            var dCalc = new Calculator<double>();
            var y = dCalc.Add(1.1, 2.2);
            Console.WriteLine(y);

        }
    }
}
