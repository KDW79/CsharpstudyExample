using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_CreateObjFromItf
{
    using System.Runtime.InteropServices;
    using Excel = Microsoft.Office.Interop.Excel;

    class Program
    {
        static void Main(string[] args)
        {

            var excel = new Excel.Application();
            ICar c = new ICar();
            c.Drive();
        }
    }

    [CoClass(typeof(Car)) ]
    [ComImport]
    [Guid("510E9CB1-5F91-4DA6-A430-EE0486F8F94C")]
    interface ICar
    {
        void Drive();
    }

    class Car: ICar
    {
        public void Drive()
        {
            System.Console.WriteLine("Drive");
        }
    }
}
