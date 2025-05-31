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

            int x = 0;

            for (int i = count; i > 0; i--)
            {
                for (int j = 0; j < x; j++)
                {
                    sb.Append(" ");
                }
                for (int j = i * 2 -1; j > 0; j--)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
                x++;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
