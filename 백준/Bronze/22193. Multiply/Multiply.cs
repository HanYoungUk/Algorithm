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

            BigInteger A = BigInteger.Parse(Console.ReadLine());
            BigInteger B = BigInteger.Parse(Console.ReadLine());

            BigInteger result = A * B;

            Console.WriteLine(result);
        }
    }
}
