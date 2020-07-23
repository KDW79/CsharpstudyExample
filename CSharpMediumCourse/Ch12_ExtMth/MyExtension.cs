using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_ExtMth
{
    public static class MyExtension
    {
        public static bool IsEven(this int a)
        {
            return a % 2 == 0;
        }

        // class 확장메서드
        public static string DashAppend(this string s, string text)
        {
            return s + "-" + text;
        }

        //
        public static int Modulo(this Calc calc, int a, int b)
        {
            return a % b;
        }
    }
}
