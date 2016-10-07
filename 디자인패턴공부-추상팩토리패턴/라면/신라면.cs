using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public class 신라면 : 라면
    {
        public 신라면()
        {
            base.가격 = 1000;
            base.이름 = "신라면";
        }
    }
}
