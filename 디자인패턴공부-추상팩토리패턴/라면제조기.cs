using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    public class 라면제조기 : 제조기
    {
        string name = "라면제조기";
        public 라면제조기()
        {

        }
        //public 라면제조기(string 이름)
        //{
        //    상품 상품 = 상품내놔(이름);
        //}

        public 상품 상품내놔(string 이름)
        {
            if (이름.Equals("신라면")) return new 신라면();
            if (이름.Equals("진라면")) return new 진라면();
            if (이름.Equals("삼양라면")) return new 삼양라면();
            return null;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
