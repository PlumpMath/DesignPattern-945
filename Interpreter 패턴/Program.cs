using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = "";

            Console.WriteLine("커피에 추가할 옵션을 선택해주세요.");

            Console.WriteLine("시럽 추가 하시겠습니까? y/n");
            string syrupSelection = Console.ReadLine().Equals("y") ? "-s" : "";

            Console.WriteLine("샷 추가 하시겠습니까? y/n");
            string ShotSelection = Console.ReadLine().Equals("y") ? "-t" : "";

            Console.WriteLine("휘핑크림 추가 하시겠습니까? y/n");
            string WcSelection = Console.ReadLine().Equals("y") ? "-w" : "";

            order = "a " + syrupSelection + " " + ShotSelection + " " + WcSelection;
            Evaluator sentence = new Evaluator(order);
            string result = sentence.interpret();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
