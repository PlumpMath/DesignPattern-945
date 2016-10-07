using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    class 세트자판기
    {
        private 세트제조기 제조기;

        public 세트자판기(string select)
        {
            switch (select)
            {
                case "1":
                    this.제조기 = new 라면제조기();
                    break;
                case "2":
                    this.제조기 = new 볶음밥제조기();
                    break;
                case "3":
                    this.제조기 = new 햄버거제조기();
                    break;
            }
        }
        public void 제조하기()
        {
            제조기.메인요리제조();
            제조기.보조요리제조();
            제조기.음료제조();
        }
        public void 가져오기()
        {
            제조기.가져가기();
        }
    }
}
