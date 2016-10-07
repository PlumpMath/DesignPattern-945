using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public abstract class 라면 : 상품
    {
        public string 이름;
        public int 가격;

        string 상품.getName()
        {
            return 이름;
        }

        int 상품.getPrice()
        {
            return 가격;
        }

        string 상품.getProductInfo()
        {
            return 이름 + "의 가격은 " + 가격 + "원 입니다.";
        }
    }
}
