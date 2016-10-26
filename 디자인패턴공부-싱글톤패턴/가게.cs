using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_싱글톤패턴
{
    class 가게
    {
        private static 가게 가게건물;
        private bool 가게전등= false;
        private int 상품갯수 = 0;

        private 가게()
        {
        }

        public static 가게 가게호출()
        {
            if (가게건물 == null) 가게건물 = new 가게();
            return 가게건물;
        }

        public void 가게전등스위치()
        {
            if (가게전등) 가게전등 = false;
            else 가게전등 = true;
        }

        public void 상품사들이기()
        {
            상품갯수++;
        }

        public bool 불빛확인()
        {
            return 가게전등;
        }

        public int 상품확인()
        {
            return 상품갯수;
        }

        public string 가게의_현재상태()
        {
            string 불빛 = 가게전등 ? "켜" : "꺼";
            return $@"가게의 전등은 {불빛}져있고, 진열된 상품의 갯수는 {상품갯수}개다.";
        }
    }
}
