using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    public class 부장 : 직원
    {
        public string 이름 { get; set; }
        과장 과장;

        public 부장(string 이름, 과장 과장)
        {
            this.이름 = 이름;
            this.과장 = 과장;
        }
        public void 명령()
        {
            Console.WriteLine(이름 + " 부장이 " + 과장.이름 + " 과장에게 명령한다.");
            과장.일하기();
        }

        public void 일하기()
        {
            Console.WriteLine(이름 + " 부장이 일한다.");
        }
    }
}
