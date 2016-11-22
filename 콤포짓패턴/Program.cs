using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 콤포짓패턴
{
    class Program
    {
        static void Main(string[] args)
        {
            대리 대리1 = new 대리("홍길똥");
            사원 사원1 = new 사원("고은혜");
            사원 사원2 = new 사원("김개똥");
            사원 사원3 = new 사원("이마바");
            사원 사원4 = new 사원("박아자");

            List<직원> 사원리스트 = new List<직원>();
            사원리스트.Add(대리1);
            사원리스트.Add(사원1);
            사원리스트.Add(사원2);
            사원리스트.Add(사원3);
            사원리스트.Add(사원4);

            과장 과장 = new 과장("김미나", 사원리스트);

            부장 부장 = new 부장("김철수", 과장);


            부장.명령();
            Console.ReadLine();
        }
    }
}
