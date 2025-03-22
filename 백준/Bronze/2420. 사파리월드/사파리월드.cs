using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            long a = long.Parse(arr[0]);
            long b = long.Parse(arr[1]);

            long minus = Math.Abs(a - b);

            Console.WriteLine(minus);
        }
    }
}
