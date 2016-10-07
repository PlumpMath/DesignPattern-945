using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 디자인패턴공부_추상팩토리패턴.햄버거;

namespace 디자인패턴공부_추상팩토리패턴
{
    public class 햄버거제조기 : 제조기
    {
        string name = "햄버거제조기";

        //public 햄버거제조기(string 이름)
        //{
        //    상품 상품 = 상품내놔(이름);
        //}
        public 상품 상품내놔(string 이름)
        {
            if (이름.Equals("치즈")) return new 치즈버거();
            if (이름.Equals("새우")) return new 새우버거();
            if (이름.Equals("불고기")) return new 불고기버거();
            return null;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
