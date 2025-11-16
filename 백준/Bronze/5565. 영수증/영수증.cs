using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int remain = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i == 0) // 첫번째꺼는 합임.
                {
                    sum = int.Parse(Console.ReadLine());
                    continue;
                }

                remain += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum - remain);
        }
    }
}
