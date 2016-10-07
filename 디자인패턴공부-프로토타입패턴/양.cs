using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    class 양 : 동물
    {
        public override 동물 Clone()
        {
            양 양 = (양)MemberwiseClone();
            양.이름 = "양돌이";
            양.울음소리 = "메에메에";
            return 양;
        }
    }
}
