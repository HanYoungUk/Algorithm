using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            for (int i = N; i >= 1; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());   
        }
    }
}