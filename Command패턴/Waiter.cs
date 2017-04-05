using Command패턴.명령;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command패턴
{
    public class Waiter
    {
        Command paper;
        public void TakeOrder(string order)
        {
            Console.WriteLine("[ Waiter ] " + order + " TakeOrder...");
            paper = new OrderCommand(order);
        }
        public void Give()
        {
            Console.WriteLine("[ Waiter ] Delivery an Order Sheet...");
            paper.execute();
        }
    }
}
