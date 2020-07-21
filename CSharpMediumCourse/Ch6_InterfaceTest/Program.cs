using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISendable> deliveryMethods = new List<ISendable>();
            deliveryMethods.Add(new EmailMessage("holycow@hyundai.com"));
            deliveryMethods.Add(new EmailMessage("holycow@hyundai.com"));
            deliveryMethods.Add(new EmailMessage("holycow@hyundai.com"));
            deliveryMethods.Add(new EmailMessage("holycow@hyundai.com"));
            Alert(deliveryMethods, "Test", "Test msg...");
        }

        private static void Alert(List<ISendable> deliveryMethods, string title, string msg)
        {
            foreach (ISendable s in deliveryMethods)
            {
                s.Send(title, msg);
            }
        }
    }
}
