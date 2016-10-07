using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 디자인패턴공부_빌더패턴
{
    abstract class 세트제조기
    {
        protected string name;
        public virtual void 메인요리제조()
        {
        }

        public virtual void 보조요리제조()
        {
        }

        public virtual void 음료제조()
        {
        }
        public virtual void 가져가기()
        {
        }
    }
}
