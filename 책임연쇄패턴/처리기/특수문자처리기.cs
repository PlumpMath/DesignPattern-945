using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 책임연쇄패턴.처리기
{
    class 특수문자처리기 : 처리기
    {
        public string 처리하기(string 입력받은값)
        {
            Console.WriteLine(" [ 특수문자처리기 가동 ] ");
            return "!~" + 입력받은값 + "~!";
        }
    }
}
