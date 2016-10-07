using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이것저것테스트
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(var i = 999; i >= 100; i--)
            {
                for(var j = 999; j >= 100; j--)
                {
                    int checkValue = i * j;
                    int valueLength = checkValue.ToString().Length;
                    bool isResult = isPalindrome(valueLength,checkValue.ToString());
                    if (isResult) Console.WriteLine(checkValue);
                }
            }



            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool isPalindrome(int length, string value)
        {
            bool result = false;
            char[] valueArr = value.ToArray();

            for(var i = 0; i < valueArr.Length/2; i++)
            {
                if (valueArr[i] != valueArr[(valueArr.Length - i)-1]) return false;
                if (i == (valueArr.Length-i)) return true;
            }

            return result;
        }
    }
}
