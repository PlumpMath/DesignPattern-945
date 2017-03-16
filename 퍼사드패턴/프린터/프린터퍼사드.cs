using System;

namespace 퍼사드패턴.프린터
{
    public class 프린터퍼사드
    {
        룰러 룰러 = new 룰러();
        잉크 잉크 = new 잉크();
        //종이 종이;
        
        private void 종이넣기(종이 종이)
        {
            종이 = new 종이();
        }

        private void 종이가져오기()
        {
            Console.WriteLine("종이 가져오는 중...");
        }

        private void 출력하기()
        {
            Console.WriteLine("출력하는 중...");
        }

        private void 종이내보내기()
        {
            Console.WriteLine("결과물 내보내는 중...");
            Console.ReadLine();
        }

        public void 프린트하기(종이 종이)
        {
            종이넣기(종이);
            종이가져오기();
            출력하기();
            종이내보내기();
        }
    }
}
