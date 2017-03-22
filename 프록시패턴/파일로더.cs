using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프록시패턴
{
    class 파일로더 : 로더
    {
        string 파일이름 = "";

        public 파일로더(string 파일이름)
        {
            this.파일이름 = 파일이름;
        }

        public void 이미지로드()
        {
            Console.WriteLine("======이미지 파일 로드 완료=========");
        }

        public void 텍스트로드()
        {
            Console.WriteLine("======텍스트 파일 로드 완료=========");
        }

        public void 파일로드()
        {
        }
    }
}
