using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    break;
                }

                if(x >= n && x % n == 0) // 배수
                {
                    sb.AppendLine($"{x} is a multiple of {n}.");
                }
                else 
                {
                    sb.AppendLine($"{x} is NOT a multiple of {n}.");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
