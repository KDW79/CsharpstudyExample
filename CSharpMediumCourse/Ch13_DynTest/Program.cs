using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_DynTest
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = "1";
            Console.WriteLine(a.GetType());
            a = 123;
            Console.WriteLine(a.GetType());

            // object vs dynamic
            object i = 10;
            i = (int)i + 20;
            i = "s";
            string s = ((string)i).ToUpper();

            dynamic d = 10;
            d = d + 20;
            d = "Hello";
            string ss = d.ToUpper();

        }

        void ExpandoTest()
        {
            dynamic person = new ExpandoObject();
            person.Name = "Kim";
            person.Age = 10;

            person.DisplayData = (Action)(() =>
            {
                Console.WriteLine($"{person.Name}: {person.Age}");
            });

            person.AgeChanged = null;

            person.ChangeAge = (Action<int>)((age) =>
            {
                person.Age = age;
                if (person.AgeChanged != null)
                {
                    person.AgeChanged(this, EventArgs.Empty);
                }
            });

            new Class2().Run(person);
        }
    }

    class Class1
    {
        public void Test()
        {
            dynamic t = new { Name = "Kim", Age = 25 };
            new Class2().Run(t);
        }

    }

    class Class2
    {
        public void Run(dynamic o)
        {
            // dynamic 타입의 속성 직접 사용
            Console.WriteLine(o.Name);
            Console.WriteLine(o.Age);
        }
    }
}
