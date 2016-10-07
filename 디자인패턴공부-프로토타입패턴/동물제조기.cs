using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    public class 동물제조기
    {
        public enum 동물이름
        {
            개,
            고양이,
            양
        }
        private static Dictionary<동물이름, 동물> 프로토타입 = new Dictionary<동물이름, 동물>();
        public 동물제조기()
        {
            프로토타입.Add(동물이름.개, new 개());
            프로토타입.Add(동물이름.고양이, new 고양이());
            프로토타입.Add(동물이름.양, new 양());
        }

        public 동물 동물탄생시키기(동물이름 이름)
        {
            return 프로토타입[이름].Clone();
        }
    }
}
