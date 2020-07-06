using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch1_ModLog;

namespace Ch1_ModApp
{
    public class Animal
    {
        private int id;
        protected string name;

        protected void Eat()
        {
            Console.WriteLine("쩝쩝~");
        }

    }

    class Dog : Animal
    {
        public void CheckIdentify()
        {
            Console.WriteLine("{0}", name);
            Eat();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogSuccess("");

            string s = logger.LogDirectory;
            Console.WriteLine(s);

            Dog dog = new Dog();
            dog.CheckIdentify();
           
        }
    }
}
