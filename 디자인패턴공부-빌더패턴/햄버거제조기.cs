using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    class 햄버거제조기 : 세트제조기
    {
        string 햄버거 { get; set; }
        string 감자튀김 { get; set; }
        string 콜라 { get; set; }
        public 햄버거제조기()
        {
            base.name = "햄버거";
        }
        public override void 메인요리제조()
        {
            base.메인요리제조();
            Console.WriteLine("햄버거 만드는 중입니다.");
            햄버거 = "완성된 햄버거";
        }

        public override void 보조요리제조()
        {
            base.보조요리제조();
            Console.WriteLine("감자튀김 만드는 중입니다.");
            감자튀김 = "완성된 감자튀김";
        }

        public override void 음료제조()
        {
            base.음료제조();
            Console.WriteLine("콜라를 컵에 담는 중입니다.");
            콜라 = "완성된 콜라";
        }

        public override void 가져가기()
        {
            Console.WriteLine(햄버거+"와 "+감자튀김+"과 "+콜라+"가 나왔습니다.");
        }
    }
}
