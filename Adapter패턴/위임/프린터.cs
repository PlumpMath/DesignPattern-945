using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter패턴.위임
{
    class 프린터 : 강화된프린터
    {
        private string 내용;
        public 프린터()
        {
            내용 = "테스트내용";
        }

        public string 내용출력()
        {
            return 내용;
        }
    }
}
