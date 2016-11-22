using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    public class 과장 : 직원
    {
        public string 이름 { get; set; }
        IList<직원> 사원들;

        public 과장(string 이름, List<직원> 사원리스트)
        {
            this.이름 = 이름;
            사원들 = 사원리스트;
        }

        public void 명령()
        {
            for (var i = 0; i < 사원들.Count; i++)
            {
                Console.WriteLine(이름 + " 과장이 " + 사원들[i].GetType().Name + " " + 사원들[i].이름 + "에게 명령한다.");
                사원들[i].일하기();
            }
        }

        public void 일하기()
        {
            Console.WriteLine(이름 + " 과장이 일한다.");
            명령();
        }
    }
}
