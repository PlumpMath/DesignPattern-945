using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator패턴
{
    public class 숫자공뽑기기계Iterator : Iterator
    {
        private 숫자공뽑기기계 뽑기기계;
        private int index;
        public 숫자공뽑기기계Iterator(숫자공뽑기기계 기계)
        {
            this.뽑기기계 = 기계;
            this.index = 0;
        }

        public bool hasNext()
        {
            if (index < 뽑기기계.숫자공갯수()) return true;
            else return false;
        }

        public object next()
        {
            숫자공 숫자공 = 뽑기기계.숫자공꺼내기(index);
            index++;
            return 숫자공;
        }
    }
}
