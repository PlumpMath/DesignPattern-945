using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    class 라면제조기 : 세트제조기
    {
        string 라면 { get; set; }
        public 라면제조기()
        {
            base.name = "라면";
        }
        public override void 메인요리제조()
        {
            base.메인요리제조();
            Console.WriteLine("라면을 만들고 있습니다.");
            라면 = "완성된 라면";
        }

        public override void 가져가기()
        {
            Console.WriteLine(라면+"나왔습니다.");
        }
    }
}
