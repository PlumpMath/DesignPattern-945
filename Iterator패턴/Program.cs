using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            숫자공뽑기기계 뽑기기계 = new 숫자공뽑기기계(7);
            // 숫자 1~45 랜덤으로 넣기... 7개
            Random r = new Random();
            while (뽑기기계.숫자공갯수() < 7)
            {
                Console.WriteLine(뽑기기계.숫자공갯수()+1 + "번째 공을 뽑습니다.");
                뽑기기계.숫자공넣기(new 숫자공(r.Next(1, 46)));
            }

            Iterator iterator = 뽑기기계.iterator();
            while (iterator.hasNext())
            {
                숫자공 숫자공 = (숫자공)iterator.next();
                Console.Write(숫자공.숫자보기() + " ");
            }
            Console.ReadLine();
        }
    }
}
