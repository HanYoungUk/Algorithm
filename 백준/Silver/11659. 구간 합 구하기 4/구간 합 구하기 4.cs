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

            string[] arr = Console.ReadLine().Split(" ");

            int M = int.Parse(arr[1]);

            string[] arr2 = Console.ReadLine().Split(" ");

            long[] S = new long[arr2.Length + 1];

            for (int i = 1; i <= arr2.Length; i++)
            {
                S[i] = S[i - 1] + int.Parse(arr2[i - 1]);
            }

            for (int i = 0; i < M; i++)
            {
                string[] answer = Console.ReadLine().Split(" ");

                int x = int.Parse(answer[0]);
                int y = int.Parse(answer[1]);



                sb.AppendLine((S[y] - S[x - 1]).ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
