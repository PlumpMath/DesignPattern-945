using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class Coffee : Expression
    {
        string name = "";
        public Coffee(string type)
        {
            if (type.Equals("a")) name = "아메리카노";
            if (type.Equals("b")) name = "카페라떼";
            if (type.Equals("c")) name = "캬라멜 마끼야또";
            else name = "카페모카";
        }
        public string interpret()
        {
            Console.WriteLine("커피 제조중...");
            return name;
        }
    }
}
