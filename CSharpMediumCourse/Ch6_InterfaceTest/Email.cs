using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_InterfaceTest
{
    abstract class MessageBase
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }
        public string Message { get; set; }

        protected void DebugMessageInfo()
        {
            Debug.WriteLine("Message Id: {0}", id);
            Debug.WriteLine("To: {0}", ToWhom);
            Debug.WriteLine("Message: {0}", Message);
        }
    }

    class EmailMessage : MessageBase, ISendable
    {

        public string EmailAddress { get; set; }

        public EmailMessage(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        private string emailAddress = "holycow@hyundai.com";

        public void Send(string title, string msg)
        {
            MailMessage mailMsg = new MailMessage("holycow@hyundai.com", this.EmailAddress, title, msg);
            SmtpClient smtp = new SmtpClient("smtp.hmc.co.kr", 25);
            smtp.EnableSsl = false;
            smtp.Credentials = new NetworkCredential(@"autos\5326562", "u5326562!");
            smtp.Send(mailMsg);
            Console.WriteLine($"{msg} to {emailAddress}");
        }

        public bool ValidateEmail()
        {
            //...
            return true;
        }
    }


}
