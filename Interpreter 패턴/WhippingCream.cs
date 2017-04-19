using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class WhippingCream : Expression
    {
        public string interpret()
        {
            Console.WriteLine("휘핑크림 얹는 중");
            return " 휘핑크림이 얹어진 ";
        }
    }
}
