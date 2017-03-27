using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 책임연쇄패턴.처리기
{
    class 숫자처리기 : 처리기
    {
        처리기 다음;
        public 숫자처리기(처리기 다음처리기)
        {
            다음 = 다음처리기;
        }
        public string 처리하기(string 입력받은값)
        {
            int 결과;
            if (!int.TryParse(입력받은값, out 결과))
            {
                return 다음.처리하기(입력받은값);
            }
            else
            {
                결과 = 실제처리(결과);
            }
            return 결과.ToString();
        }

        private int 실제처리(int 결과)
        {
            Console.WriteLine(" [ 숫자처리기 가동 ]");
            return 결과 + 100000;
        }
    }
}
