using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator패턴
{
    public class 숫자공
    {
        private int 숫자;

        public 숫자공(int 숫자)
        {
            this.숫자 = 숫자;
        }

        public int 숫자보기()
        {
            return 숫자;
        }
    }
}
