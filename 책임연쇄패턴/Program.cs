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
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
