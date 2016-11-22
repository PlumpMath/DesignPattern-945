using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    public interface 직원
    {
        string 이름 { get; set; }
        void 명령();
        void 일하기();
    }
}
