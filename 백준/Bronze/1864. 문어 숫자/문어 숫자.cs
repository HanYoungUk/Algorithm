using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "#")
                    break;

                // 기호 변환 (단 /는 그대로 둠)
                str = str.Replace("-", "0").Replace("\\", "1").Replace("(", "2").Replace("@", "3")
                    .Replace("?", "4").Replace(">", "5").Replace("&", "6").Replace("%", "7");

                long result = 0;
                foreach (char ch in str)
                {
                    int value = (ch == '/') ? -1 : ch - '0';
                    result = result * 8 + value;
                }

                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
