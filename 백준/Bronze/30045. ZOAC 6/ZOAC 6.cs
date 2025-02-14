using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < num; i++)
            {
                var s = Console.ReadLine();

                if (s.Contains("01") || s.Contains("OI"))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
