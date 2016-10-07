using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    public abstract class 동물
    {
        protected string 이름;
        protected string 울음소리;
        protected int 다리갯수 { get; set; } = 4;
        protected int 생명력 { get; set; } = 100;
        protected string 타입 { get; set; } = "포유류";
        public void 짖기()
        {
            Console.WriteLine(울음소리);
        }
        public void 정보보기()
        {
            Console.WriteLine("이름 : "+이름);
            Console.WriteLine("울음소리 : "+울음소리);
            Console.WriteLine("다리갯수 : "+다리갯수);
        }

        public override string ToString()
        {
            return $@"
    이름 : {이름}
    울음소리 : {울음소리}
    다리갯수는 {다리갯수}개
    생명력은 {생명력}
    {이름}은 {타입}이다.";
        }

        public abstract 동물 Clone();
    }
}
