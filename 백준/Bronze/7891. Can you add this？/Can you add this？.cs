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

            int count = int.Parse(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                long A = long.Parse(arr[0]);
                long B = long.Parse(arr[1]);

                BigInteger sum = A + B;

                sb.AppendLine(sum.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
