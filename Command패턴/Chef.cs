using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command패턴
{
    public class Chef
    {
        public void cook(string menu)
        {
            Console.WriteLine("[ Chef ]"+menu + "Cooking...");
        }
    }
}
