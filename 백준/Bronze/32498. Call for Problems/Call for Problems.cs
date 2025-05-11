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
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 1)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
