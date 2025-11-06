using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < count; i++) // 각 문자열을 담음
            {
                string str = Console.ReadLine();

                list.Add(str);
            }

            int mind = int.Parse(Console.ReadLine());

            if (mind == 1) // 그냥 그대로 출력
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sb.AppendLine(list[i]);
                }
            }
            else if (mind == 2) // 좌우 반전
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string s = new string(list[i].Reverse().ToArray());

                    sb.AppendLine(s);
                }
            }
            else // 상하 반전
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    sb.AppendLine(list[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
