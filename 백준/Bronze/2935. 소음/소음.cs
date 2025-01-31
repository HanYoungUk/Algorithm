using System;
using System.Text;
using System.Numerics;


namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var num = Console.ReadLine();

            var s = Console.ReadLine();

            var num2 = Console.ReadLine();

            if (s.Equals("*"))
            {
                BigInteger big = BigInteger.Parse(num) * BigInteger.Parse(num2);

                Console.WriteLine(big);
            }
            else
            {
				BigInteger big = BigInteger.Parse(num) + BigInteger.Parse(num2);

                Console.WriteLine(big);
			}
        }
    }
}
