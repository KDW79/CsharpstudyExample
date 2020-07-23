using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# 확장메서드 (Extension Method)
namespace Ch12_ExtMth
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            //bool b = MyUtility.IsEven(a);
            bool b = a.IsEven();
            Console.WriteLine(b);
            b = 100.IsEven();
            Console.WriteLine(b);

            string s = "ABC";
            string s2 = s.DashAppend("DEF");
            Console.WriteLine(s2);

            Calc c = new Calc();
            int res = c.Modulo(5, 3);
            Console.WriteLine(res);

            // interface 확장메서드
            var list = new List<string> { "Alexa", "Pane", "Jane", "Alex" };
            var aNames = list.Where(p => p.StartsWith("A"));

        }



    }
}
