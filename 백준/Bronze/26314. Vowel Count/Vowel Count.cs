using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();

            // 모음이 자음보다 많으면 1 아니면 0
            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                int j = 0; // 자음
                int m = 0; // 모음

                for(int k = 0; k < str.Length; k++)
                {
                    if (str[k] == 'a' || str[k] == 'e' || str[k] == 'i' || str[k] == 'o' || str[k] == 'u')
                    {
                        m++;
                    }
                    else
                    {
                        j++;
                    }
                }

                if(j >= m)
                {
                    sb.AppendLine(str);
                    sb.AppendLine("0");
                }
                else
                {
                    sb.AppendLine(str);
                    sb.AppendLine("1");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
