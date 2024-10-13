using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            BigInteger x = BigInteger.Parse(arr[0]);
            BigInteger y = BigInteger.Parse(arr[1]);

            Console.WriteLine(x / y);
            Console.WriteLine(x % y);
        }
    }
}