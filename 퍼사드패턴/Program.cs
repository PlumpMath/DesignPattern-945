using 퍼사드패턴.프린터;

namespace 퍼사드패턴
{
    public class Program
    {
        static void Main(string[] args)
        {
            프린터퍼사드 프린터 = new 프린터퍼사드();
            종이 종이 = new 종이();

            프린터.프린트하기(종이);
        }
    }
}
