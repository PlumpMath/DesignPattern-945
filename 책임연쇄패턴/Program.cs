using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 책임연쇄패턴;
using 책임연쇄패턴.처리기;

namespace 책임연쇄패턴
{
    public class Program
    {
        static void Main(string[] args)
        {
            책임연쇄패턴.처리기.처리기 처리기 = new 숫자처리기(new 문자열처리기(new 특수문자처리기()));
            while (true)
            {
                Console.WriteLine("문자를 입력해주세요. q: 종료");
                string 입력한문자 = Console.ReadLine();
                if (입력한문자.Equals("q")) return;
                Console.WriteLine("====== 처리 결과 ======");
                Console.WriteLine(처리기.처리하기(입력한문자));
            }

            Console.ReadLine();
        }
    }
}
