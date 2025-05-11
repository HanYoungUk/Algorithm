using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 1) // 홀수 일 때
                {
                    result += 3;
                }
                else
                {
                    result -= 2;
                }

            }

            Console.WriteLine(result);
        }
    }
}
