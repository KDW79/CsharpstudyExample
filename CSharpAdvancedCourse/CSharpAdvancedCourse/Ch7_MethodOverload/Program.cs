using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_MethodOverload
{
    class Calculator
    {

        public double Result { get; protected set; }

        //public void Add (int a, int b)
        //{
        //    Result = a + b;
        //}

        //public void Add (double a, double b)
        //{
        //    Result = a + b;
        //}

        //public void Add (string a, string b)
        //{
        //    // 테스트용
        //}

        // 컴파일러는 리턴타입을 따지지 않는다. 매개변수만 따진다.
        public string Change(int a)
        {
            return a.ToString();
        }         

        public char[] Change(double a)
        {
            string s = a.ToString();
            return s.ToCharArray();
        }

        public void Print (int a, int b = 10)
        {
            Console.WriteLine($"{a},{b}");
        }

        public void print(int a)
        {
            Console.WriteLine(a);
        }

        // Using Named Parameter
        public void PrintValue(int a)
        {
            Console.WriteLine(a);
        }

        public void PrintValue(double b)
        {
            Console.WriteLine(b);
        }

        public virtual void Add(int a, int b)
        {
            Result = a + b;
        }
    }

    class MyCalculator : Calculator
    {
        // 우선순위 2
        public override void Add(int a, int b)
        {
            Result = a + b;
        }
        
        // 우선순위 1
        public void Add(double a, double b)
        {
            Result = a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c = new Calculator();
            //c.Add(1.0, 2.0);
            //char[] a = c.Change(1);
            //c.Print(1); // Print (int a) 가 실행됨. Print (int a, int b = 10)은 옵셔널로 유사하지만 더 매칭되는 메쏘드가 있다면 그것이 먼저 실행됨.

            // b라는 파라메터 이름을 기입했기 때문에 그 대입값이 무엇이든 PrintValue(double b)가 실행된다.
            //c.PrintValue(b: 1);

            MyCalculator mc = new MyCalculator();
            mc.Add(1, 2);


            // 컴파일러가 매개변수를 판단하여 일치하는 메쏘드를 찾고 없다면 가장 호환 가능한 메쏘드를 찾는다. 
            //var c1 = new Calculator();
            //c1.Add(2, 4);


        }
    }
}
