using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 프록시패턴
{
    interface 로더
    {
        void 파일로드();
        void 이미지로드();
        void 텍스트로드();
    }
}
