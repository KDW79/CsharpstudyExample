using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// C# 익명타입 실습
namespace Ch11_AnonyType
{
    class Program
    {
        static void Main(string[] args)
        {
            // 익명타입
            var t = new
            {
                Name = "홍길동",
                Age = 20,
                Phone = "02-222-2222"
            };

            int age = t.Age;
            //t.Age = 1;
            Type typ = t.GetType();

            // LINQ
            var v = new[]
            {
                new {Name = "Lee", Age = 33, Phone = "02-111-1111"},
                new {Name = "Kim", Age = 25, Phone = "02-222-2222"},
                new {Name = "Pak", Age = 47, Phone = "02-333-3333"},

            };

            // LINQ를 이용해 30세 이상인 사람들 조회
            var list = v.Where(p => p.Age >= 30).Select(p => new { 이름 = p.Name, 나이 = p.Age });
            foreach (var s in list)
            {
                Debug.WriteLine(s.이름 + s.나이);
            }
        }
    }
}
