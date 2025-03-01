using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string balance = Console.ReadLine();
            string[] two = balance.Split(" ");
            long A = long.Parse(two[0]);
            long B = long.Parse(two[1]);

            long cost = long.Parse(Console.ReadLine());

            if(A + B >= cost * 2)
            {
                Console.WriteLine(A + B - cost * 2);
            }
            else
            {
                Console.WriteLine(A + B);
            }
        }
    }
}