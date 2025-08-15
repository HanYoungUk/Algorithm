using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // x사 1리터당 A엔
            // Y사 기본요금 B엔, C리터 이하면 기본요금, 넘었을 경우 B엔 + D엔 * 1리터
            // 사람이 사용하는 것은 P리터
            // 최대한 싸게

            int x = int.Parse(Console.ReadLine()); // x사의 1리터당 요금
            int y = int.Parse(Console.ReadLine()); // y사의 기본요금
            int c = int.Parse(Console.ReadLine()); // y사의 상한선
            int d = int.Parse(Console.ReadLine()); // y사의 추가요금
            int p = int.Parse(Console.ReadLine()); // 인간이 사용한 리터

            int Xcor = x * p;
            int Ycor = 0;

            if (c < p) // 넘었을 경우
            {
                Ycor = y + (p - c) * d;
            }
            else // 안넘었을 경우
            {
                Ycor = y;
            }


            if (Xcor > Ycor) // Xcor가 높을 경우
            {
                Console.WriteLine(Ycor);
            }
            else if (Ycor >= Xcor)
            {
                Console.WriteLine(Xcor);
            }
        }
    }
}
