using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴.햄버거
{
    public class 불고기버거 : 햄버거
    {
        public 불고기버거()
        {
            base.이름 = "불고기버거";
            base.가격 = 4000;
        }
    }
}
