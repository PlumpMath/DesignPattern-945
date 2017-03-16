using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 플라이웨이트패턴.FlyWeight;
using 플라이웨이트패턴.Item;

namespace 플라이웨이트패턴
{
    public class 용사
    {
        Dictionary<string, int> 인벤토리 = new Dictionary<string, int>();
        public string 인벤토리확인()
        {
            string result = "";
            for (var i = 0; i < 인벤토리.Count; i++)
            {
                string 아이템이름 = 인벤토리.ElementAt(i).Key;
                int 아이템개수 = 인벤토리.ElementAt(i).Value;
                for (var j = 0; j < 아이템개수; j++)
                {
                    아이템 아이템 = ItemFactory.아이템객체가져오기(아이템이름);
                    result += 아이템.아이템상세정보();
                }
            }
            return result;
        }

        public string 요약된인벤토리확인()
        {
            string result = "";
            for (var i = 0; i < 인벤토리.Count; i++)
            {
                string 아이템이름 = 인벤토리.ElementAt(i).Key;
                int 아이템개수 = 인벤토리.ElementAt(i).Value;
                아이템 아이템 = ItemFactory.아이템객체가져오기(아이템이름);
                result += "개수 : [ " + 아이템개수 + " ] " + 아이템.아이템상세정보();
            }
            return result;
        }

        public void 아이템획득(string 아이템)
        {
            if (!인벤토리.ContainsKey(아이템))
            {
                //생성
                인벤토리.Add(아이템, 1);
            }
            else
            {
                //추가
                인벤토리[아이템] = 인벤토리[아이템] + 1;
            }
        }
    }
}
