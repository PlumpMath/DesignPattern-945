using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    public class 대리 : 직원
    {
        public string 이름 { get; set; }

        public 대리(string 이름)
        {
            this.이름 = 이름;
        }

        public void 명령()
        {
            Console.WriteLine(이름 + " 대리도 그냥 일하자");
            일하기();
        }

        public void 일하기()
        {
            Console.WriteLine(이름 + " 대리가 일한다.");
        }
    }
}
