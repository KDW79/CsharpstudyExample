﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_MsgApp
{
    abstract class MessageBase
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }
        public string Message { get; set; }

        //public virtual void Send()
        //{
        //    Console.WriteLine($"Send Message to {ToWhom}:");
        //    Console.WriteLine($"{Message}");
        //}

        public abstract void Send();

        protected void DebugMessageInfo()
        {
            Debug.WriteLine("Message Id: {0}", id);
            Debug.WriteLine("To: {0}", ToWhom);
            Debug.WriteLine("Message: {0}", Message);
        }
    }

    class EmailMessage : MessageBase
    {
        public string Email { get; set; }

        public EmailMessage(string email)
        {
            Email = email;
        }

        public override void Send()
        {
            MailMessage msg = new MailMessage("holycow@hyundai.com", this.Email, "제목", this.Message);
            SmtpClient smtp = new SmtpClient("smtp.hmc.co.kr", 25);
            smtp.EnableSsl = false;
            smtp.Credentials = new NetworkCredential(@"autos\5326562", "u5326562!");
            smtp.Send(msg);

        }

        public void MyDebugMessageInfo()
        {
            DebugMessageInfo();
        }
    }

    class CompanyEmail : EmailMessage
    {
        public CompanyEmail(string email) : base (email)
        {

        }
    }

    class SMSMessage : MessageBase
    {
        public string PhoneNumber { get; set; }
        public override void Send()
        {

        }

    }

    //...
}
