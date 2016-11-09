using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter패턴.위임
{
    class Program
    {
        static void Main(string[] args)
        {
            강화된프린터 프린터 = new 강화된프린터();
            Console.WriteLine(프린터.p태그로감싸기());
            Console.WriteLine(프린터.span태그로감싸기());
            프린터 원래프린터 = new 프린터();
            Console.WriteLine(원래프린터.내용출력());
            Console.ReadLine();
        }
    }
}
