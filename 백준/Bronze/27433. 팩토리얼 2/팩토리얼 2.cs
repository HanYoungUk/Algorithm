using System;
using System.Text;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            for(int i = num; i > 0; i--)
            {
                fac *= i;
            }

            Console.WriteLine(fac);
        }
    }
}
