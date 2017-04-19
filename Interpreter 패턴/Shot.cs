using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class Shot : Expression
    {
        public string interpret()
        {
            Console.WriteLine("샷 추가 중");
            return "샷추가된 ";
        }
    }
}
