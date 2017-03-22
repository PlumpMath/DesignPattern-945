using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프록시패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            프록시파일로더 로더 = new 프록시파일로더("document.hwp");
            로더.파일로드();
            Console.ReadLine();
        }
    }
}
