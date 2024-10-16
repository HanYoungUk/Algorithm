using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              BigInteger big = BigInteger.Parse(Console.ReadLine());

              Console.WriteLine(big % 20000303);
        }
    }
}