using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    class 고양이 : 동물
    {
        public override 동물 Clone()
        {
            고양이 고양이 = (고양이)MemberwiseClone();
            고양이.이름 = "냥냥이";
            고양이.울음소리 = "야옹야옹";
            return 고양이;
        }
    }
}
