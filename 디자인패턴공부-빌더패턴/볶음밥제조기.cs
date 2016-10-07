using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    class 볶음밥제조기 : 세트제조기
    {
        string 볶음밥 { get; set; }
        string 계란국 { get; set; }
        public 볶음밥제조기()
        {
            base.name = "볶음밥";
        }
        public override void 메인요리제조()
        {
            base.메인요리제조();
            Console.WriteLine("볶음밥 만드는 중입니다.");
            볶음밥 = "완성된 볶음밥";
        }

        public override void 보조요리제조()
        {
            base.보조요리제조();
            Console.WriteLine("계란국 만드는 중입니다.");
            계란국 = "완성된 계란국";
        }
        public override void 가져가기()
        {
            Console.WriteLine(볶음밥+"과 "+계란국+"이 나왔습니다.");
        }
    }
}
