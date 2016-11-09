using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter패턴.위임
{
    abstract class 강화된프린터
    {
        프린터 프린터;
        public 강화된프린터()
        {
            프린터 = new 프린터();
        }
        public string p태그로감싸기()
        {
            string contents = "<p>" + 프린터.내용출력() + "</p>";
            return contents;
        }
    }
}
