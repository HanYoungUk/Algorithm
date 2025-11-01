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


            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string reverse = new string(str.Reverse().ToArray());

                int sum = int.Parse(str) + int.Parse(reverse);

                string s = sum.ToString();

                int x = s.Length / 2; // 중간을 찾기 위한

                int index = s.Length - 1;

                bool check = true;
                for (int j = 0; j < x; j++)
                {
                    if (s[j] == s[index--])
                    {
                        continue;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    sb.AppendLine("YES");
                }
                else
                {
                    sb.AppendLine("NO");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
