using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            // 1, 2반에는 소프트웨어개발과, 3반에는 임베디드소프트웨어개발과, 4반에는 인공지능소프트웨어개발과

            int count = int.Parse(Console.ReadLine());

            int normal = 0; // 그냥 소프트웨어
            int im = 0; // 임베디드
            int ai = 0; // AI
            int first = 0;

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");


                if (arr[0].Equals("1"))
                {
                    first++;
                    continue;
                }

                if (arr[1].Equals("1") || arr[1].Equals("2")) // 그냥 소프트웨어 과일 때
                {
                    normal++;
                }
                else if (arr[1].Equals("3")) // 임베디드
                {
                    im++;
                }
                else
                {
                    ai++;
                }

            }
            sb.AppendLine(normal.ToString());
            sb.AppendLine(im.ToString());
            sb.AppendLine(ai.ToString());
            sb.AppendLine(first.ToString());


            Console.WriteLine(sb.ToString());
        }
    }
}
