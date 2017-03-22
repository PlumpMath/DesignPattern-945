using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 프록시패턴
{
    class 프록시파일로더 : 로더
    {
        파일로더 파일로더;
        string 파일이름 = "";
        bool isLoaded = false;

        public 프록시파일로더(string 파일이름)
        {
            this.파일이름 = 파일이름;
            if (파일로더 == null)
            {
                파일로더 = new 파일로더(파일이름);
                Console.WriteLine("파일로더 생성");
            }   
        }

        public void 이미지로드()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("이미지 파일 로드 중...");
                Thread.Sleep(500);
            }
            파일로더.이미지로드();
        }

        public void 텍스트로드()
        {
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("텍스트 로드 중...");
                Thread.Sleep(150);
            }
            파일로더.텍스트로드();
        }

        public void 파일로드()
        {
            Thread T1 = new Thread(new ThreadStart(텍스트로드));
            Thread T2 = new Thread(new ThreadStart(이미지로드));
            T1.Start();
            T2.Start();
        }
    }
}
