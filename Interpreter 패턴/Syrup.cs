using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class Syrup : Expression
    {
        public string interpret()
        {
            Console.WriteLine("시럽 넣는 중");
            return "시럽넣은 ";
        }
    }
}
