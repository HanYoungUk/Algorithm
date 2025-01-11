using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger A = BigInteger.Parse(Console.ReadLine());
            BigInteger B = BigInteger.Parse(Console.ReadLine());

            string plus = (A + B).ToString();
            string minus = (A - B).ToString();
            string multiply = (A * B).ToString();
            Console.WriteLine(plus);
            Console.WriteLine(minus);
            Console.WriteLine(multiply);        
        }
    }
}