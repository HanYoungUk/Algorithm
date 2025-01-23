using System;
using System.Text;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            BigInteger a = BigInteger.Parse(arr[0]);
            BigInteger b = BigInteger.Parse(arr[1]);

            BigInteger count = 0;

            if (b > a)
            {
                for (BigInteger i = a + 1; i < b; i++)
                {
                    count++;
                    sb.Append($"{i} ");
                }
            }
            else
            {
                for (BigInteger i = b + 1; i < a; i++)
                {
                    count++;
                    sb.Append($"{i} ");
                }
            }

            Console.WriteLine(count);
            if (count == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
