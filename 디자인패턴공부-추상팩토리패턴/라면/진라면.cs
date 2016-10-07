using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public class 진라면 : 라면
    {
        public 진라면()
        {
            base.가격 = 900;
            base.이름 = "진라면";
        }
    }
}