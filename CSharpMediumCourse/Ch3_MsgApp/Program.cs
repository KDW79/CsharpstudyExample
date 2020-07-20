using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3_MsgApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailMessage em = new EmailMessage("holycow@hyundai.com");
            em.ToWhom = "김동원";
            em.Message = "테스트가 완료되었습니다.";
            em.MyDebugMessageInfo();
            em.Send();
        }
    }
}
