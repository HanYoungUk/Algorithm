using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            //      최소 3개의 더듬이와 최대 4개의 눈을 가진 TroyMartian;
            //     VladSaturnian은 최대 6개의 더듬이와 최소 2개의 눈을 가지고 있습니다.
            //     GraemeMercurian은 최대 2개의 더듬이와 최대 3개의 눈을 가지고 있습니다.

            int antenna = int.Parse(Console.ReadLine()); // 더듬이
            int eyes = int.Parse(Console.ReadLine()); // 눈

            if (antenna >= 3 && 4 >= eyes)
            {
                sb.AppendLine("TroyMartian");
            }
            if (antenna <= 6 && 2 <= eyes)
            {
                sb.AppendLine("VladSaturnian");
            }
            if (antenna <= 2 && eyes <= 3)
            {
                sb.AppendLine("GraemeMercurian");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
