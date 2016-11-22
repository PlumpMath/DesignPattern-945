using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    public class 사원 : 직원
    {

        public string 이름 { get; set; }
        public 사원(string 이름)
        {
            this.이름 = 이름;
        }
        public void 명령()
        {
            Console.WriteLine("일개 사원은 명령할 사람이 없다. 고로 일한다.");
            일하기();
        }

        public void 일하기()
        {
            Console.WriteLine(이름 + " 사원이 일한다.");
        }
    }
}
