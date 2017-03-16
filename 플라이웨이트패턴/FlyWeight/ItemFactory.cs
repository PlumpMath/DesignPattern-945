using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 플라이웨이트패턴.Item;

namespace 플라이웨이트패턴.FlyWeight
{
    public static class ItemFactory
    {
        static Dictionary<string, 아이템> 아이템저장소 = new Dictionary<string, 아이템>();
        public static void Setting()
        {
            아이템 기본검 = new 기본검();
            아이템 기본활 = new 기본활();
            아이템 기본지팡이 = new 기본지팡이();

            아이템저장소.Add("기본검", 기본검);
            아이템저장소.Add("기본활", 기본활);
            아이템저장소.Add("기본지팡이", 기본지팡이);
        }
        public static 아이템 아이템객체가져오기(string 아이템이름)
        {
            return 아이템저장소[아이템이름];
        }
    }
}
