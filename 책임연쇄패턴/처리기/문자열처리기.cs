using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 책임연쇄패턴.처리기
{
    class 문자열처리기 : 처리기
    {
        처리기 다음;
        public 문자열처리기(처리기 다음처리기)
        {
            다음 = 다음처리기;
        }
        public string 처리하기(string 입력받은값)
        {
            string 결과 = "";
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (!regexItem.IsMatch(입력받은값))
            {
                다음.처리하기(입력받은값);
            }
            else
            {
                결과 = 실제처리(입력받은값);
            }
            return 결과;
        }

        private string 실제처리(string 입력받은값)
        {
            Console.WriteLine(" [ 문자처리기 가동 ]");
            return "*" + 입력받은값 + "*";
        }
    }
}
