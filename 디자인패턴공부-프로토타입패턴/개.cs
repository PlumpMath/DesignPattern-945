using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    public class 개 : 동물
    {
        public override 동물 Clone()
        {
            개 개 = (개)MemberwiseClone();
            개.이름 = "바둑이";
            개.울음소리 = "멍멍";
            return 개;
        }
    }
}
