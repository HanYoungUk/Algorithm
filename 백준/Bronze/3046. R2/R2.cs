using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");

            int r1 = int.Parse(arr[0]); // R1
            int S = int.Parse(arr[1]); // S

            // (R1 + R2) / 2 = S
            // R2 = 2S - R1

            int r2 = 2 * S - r1;

            Console.WriteLine(r2);  
        }
    }
}