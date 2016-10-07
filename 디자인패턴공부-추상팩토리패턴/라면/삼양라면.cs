using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public class 삼양라면 :라면
    {
        public 삼양라면()
        {
            base.가격 = 950;
            base.이름 = "삼양라면";
        }
    }
}
