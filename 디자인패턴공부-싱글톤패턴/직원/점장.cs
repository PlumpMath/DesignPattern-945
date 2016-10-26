using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_싱글톤패턴
{
    class 점장
    {
        private 가게 가게 = 가게.가게호출();

        public string 가게상태보기()
        {
            return 가게.가게의_현재상태();
        }

        public void 스위치누르기()
        {
            Console.WriteLine("점장이 스위치를 눌렀다.");
            가게.가게전등스위치();
        }

        public void 상품구비()
        {
            Console.WriteLine("점장이 상품을 샀다.");
            가게.상품사들이기();
        }
    }
}
