using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 플라이웨이트패턴.FlyWeight;

namespace 플라이웨이트패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemFactory.Setting();
            용사 용사 = new 용사();
            용사.아이템획득("기본검");
            용사.아이템획득("기본검");
            용사.아이템획득("기본검");
            용사.아이템획득("기본활");
            용사.아이템획득("기본활");
            용사.아이템획득("기본지팡이");
            용사.아이템획득("기본검");

            Console.WriteLine(용사.인벤토리확인());
            Console.WriteLine(용사.요약된인벤토리확인());
            Console.ReadLine();
        }
    }
}
