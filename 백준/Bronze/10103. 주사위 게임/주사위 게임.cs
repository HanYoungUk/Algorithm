using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int round = int.Parse(Console.ReadLine());

            int cyScore = 100;
            int sdScore = 100;

            for (int i = 0; i < round; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int cy = int.Parse(arr[0]); // 창영이 점수
                int sd = int.Parse(arr[1]); // 상덕이 점수

                if (cy > sd)
                {
                    sdScore -= cy;
                }
                else if (sd > cy)
                {
                    cyScore -= sd;
                }
            }

            sb.AppendLine(cyScore.ToString());
            sb.AppendLine(sdScore.ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
