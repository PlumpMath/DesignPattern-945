using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_추상팩토리패턴
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                 Console.WriteLine();
                Console.WriteLine("원하시는 상품은 어떤 종류입니까? (라면,햄버거)  나가기 : Q");
                string product = Console.ReadLine();
                if (product.Equals("q") || product.Equals("Q")) return;

                try
                {
                    제조기 제조기 = (제조기)Activator.CreateInstance(Type.GetType("디자인패턴공부_추상팩토리패턴." + product + "제조기"));
                    Console.WriteLine(제조기.ToString() + "이 선택되었습니다.");
                    Console.WriteLine("원하시는 " + product + "의 이름을 입력해주세요.");

                    string productName = Console.ReadLine();
                    상품 결과상품 = 제조기.상품내놔(productName);
                    Console.WriteLine("==================");
                    Console.WriteLine("선택하신 " + product + "의 정보입니다.");
                    Console.WriteLine(product + "이름 : " + 결과상품.getName());
                    Console.WriteLine(product + "가격 : " + 결과상품.getPrice());
                    Console.WriteLine("==================");

                }
                catch (Exception e)
                {
                    Console.WriteLine("죄송합니다. 없는 상품입니다.");
                    continue;
                }

            }

        }
    }
}