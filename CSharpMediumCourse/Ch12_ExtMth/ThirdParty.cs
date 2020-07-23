using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_ExtMth
{
    // 3rd Party Class that cannot modify
    public sealed class Calc
    {
        public int Add(int a, int b) { return a + b; }
        public int Substract(int a, int b) { return a - b; }
        public int Multiply(int a, int b) { return a * b; }
        public int Divide(int a, int b) { return a / b; }

    }
}
