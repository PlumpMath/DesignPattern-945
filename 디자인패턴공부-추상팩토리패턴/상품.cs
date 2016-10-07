using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public interface 상품
    {
        string getName();
        int getPrice();
        string getProductInfo();
    }
}
