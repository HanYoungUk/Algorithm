using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // d1 = 가로의 길이
            // d2 = 반지름
            // 원주율 = 3.141592

            int d1 = Int32.Parse(Console.ReadLine());
            int d2 = Int32.Parse(Console.ReadLine());
            double p = 3.141592;

            double sum = (d1 * 2) + (2 * p * d2);

            Console.WriteLine(sum);
        }
    }
}