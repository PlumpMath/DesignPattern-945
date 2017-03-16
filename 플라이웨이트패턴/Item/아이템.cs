using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 플라이웨이트패턴.Item
{
    public abstract class 아이템
    {
        public string 이름;
        public int 공격력;
        public string 이름가져오기()
        {
            return 이름;
        }
        public string 아이템상세정보()
        {
            string result = "";
            result += "===== [ " + 이름 + " ] : 공격력 [ " + 공격력.ToString() + " ] \n";
            return result;
        }
    }
}
