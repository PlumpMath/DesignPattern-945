using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter패턴
{
    class 강화된프린터 : 프린터, 프린터강화
    {
        public string p태그로감싸기()
        {
            var 내용 = "<p>" + base.내용출력() + "</p>";
            return 내용;
        }

        public string span태그로감싸기()
        {
            var 내용 = "<span>" + base.내용출력() + "</span>";
            return 내용;
        }
    }
}
