using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_프로토타입패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            동물제조기 동물제조 = new 동물제조기();

            while (true)
            {
                Console.WriteLine("탄생시킬 동물을 선택하세요.");
                Console.WriteLine("1.개 2.고양이 3.양  Q.나가기");
                string 선택 = Console.ReadLine();
                if (선택.Equals("Q") || 선택.Equals("q")) return;

                동물 생성한동물 = null;
                try
                {
                    if (선택.Equals("1")) 생성한동물 = 동물제조.동물탄생시키기(동물제조기.동물이름.개);
                    if (선택.Equals("2")) 생성한동물 = 동물제조.동물탄생시키기(동물제조기.동물이름.고양이);
                    if (선택.Equals("3")) 생성한동물 = 동물제조.동물탄생시키기(동물제조기.동물이름.양);
                }
                catch (Exception e)
                {
                    Console.WriteLine("제대로 선택해주세요.");
                }
                Console.WriteLine(생성한동물.ToString());
            }

        }
    }
}
