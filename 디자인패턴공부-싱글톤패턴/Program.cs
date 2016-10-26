using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_싱글톤패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            아르바이트 알바 = new 디자인패턴공부_싱글톤패턴.아르바이트();
            점장 점장 = new 디자인패턴공부_싱글톤패턴.점장();

            Console.WriteLine(알바.가게상태보기());
            알바.상품구비();
            알바.스위치누르기();

            Console.WriteLine(점장.가게상태보기());
            점장.상품구비();
            점장.스위치누르기();

            Console.WriteLine(알바.가게상태보기());
            알바.상품구비();
            Console.WriteLine(알바.가게상태보기());
            알바.상품구비();
            알바.스위치누르기();
            Console.WriteLine(알바.가게상태보기());

            Console.ReadLine();
        }
    }
}
