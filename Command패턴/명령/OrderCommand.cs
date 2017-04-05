using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command패턴.명령
{
    public class OrderCommand : Command
    {
        Chef chef = new Chef();
        string menu = "";
        public OrderCommand(string menu)
        {
            this.menu = menu;
        }
        public void execute()
        {
            chef.cook(menu);
        }
    }
}
