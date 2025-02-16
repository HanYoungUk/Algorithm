using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
