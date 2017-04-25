using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator패턴
{
    public class 숫자공뽑기기계 : Aggregate
    {
        private 숫자공[] 숫자공들;
        private int Count = 0;

        public 숫자공뽑기기계(int index)
        {
            this.숫자공들 = new 숫자공[index];
        }

        public 숫자공 숫자공꺼내기(int index)
        {
            return 숫자공들[index];
        }

        public void 숫자공넣기(숫자공 숫자공)
        {
            if (같은숫자있는지검사(숫자공.숫자보기())) return;
            this.숫자공들[Count] = 숫자공;
            Count++;
            정렬하기();
        }

        private void 정렬하기()
        {
            for (var i = 0; i < Count; i++)
            {
                for (var j = 1 + i; j < Count; j++)
                {
                    if (숫자공들[i].숫자보기() > 숫자공들[j].숫자보기())
                    {
                        숫자공 숫자공 = 숫자공들[i];
                        숫자공들[i] = 숫자공들[j];
                        숫자공들[j] = 숫자공;
                    }
                }
            }
        }

        private bool 같은숫자있는지검사(int 숫자)
        {
            Console.Write("현재까지 뽑힌 숫자 : ");
            for (var i = 0; i < Count; i++)
            {
                Console.Write(숫자공들[i].숫자보기() + " ");
                if (숫자공들[i].숫자보기() == 숫자)
                {
                    Console.WriteLine("같은 숫자[" + 숫자 + "]가 뽑혀 다시 공을 뽑습니다.");
                    return true;
                }
            }
            Console.WriteLine();
            return false;
        }

        public int 숫자공갯수()
        {
            return Count;
        }

        public Iterator iterator()
        {
            return new 숫자공뽑기기계Iterator(this);
        }
    }
}
