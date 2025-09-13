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
                int num = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int j = 1; j <= num; j = j + 2)
                {
                    sum += j;
                }
                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
