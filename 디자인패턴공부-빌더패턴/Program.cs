using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("먹고싶은 메뉴를 골라주세요. 1. 라면 2.볶음밥 3.햄버거 Q.나가기");
                string select = Console.ReadLine();
                if (select.Equals("Q") || select.Equals("q")) return;

                세트자판기 자판기 = new 세트자판기(select);

                자판기.제조하기();
                자판기.가져오기();
            }
        }
    }
}
