using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Command패턴.Waiter();
            waiter.TakeOrder("specialMenu");
            waiter.Give();
            Console.ReadLine();
        }
    }
}
