using System;
using System.Text;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            long num1 = long.Parse(arr[0] + arr[1]);
            long num2 = long.Parse(arr[2] + arr[3]);

            BigInteger sum = num1 + num2;

            Console.WriteLine(sum.ToString());
        }
    }
}
