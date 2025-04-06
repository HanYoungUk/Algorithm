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

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                // str의 길이의 반과 그 전까지를 비교
                int half = str.Length / 2;

                if (str[half] == str[half - 1])
                {
                    sb.AppendLine("Do-it");
                }
                else
                {
                    sb.AppendLine("Do-it-Not");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
