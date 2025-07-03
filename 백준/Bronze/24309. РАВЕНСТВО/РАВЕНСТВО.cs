using System;
using System.Text;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            BigInteger x = 0;

            x = (b - c) / a;

            Console.WriteLine(x);
        }
    }
}
