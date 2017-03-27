using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 책임연쇄패턴.처리기
{
    public interface 처리기
    {
        string 처리하기(string 입력받은값);
    }
}
