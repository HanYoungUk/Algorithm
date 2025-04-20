using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int K = int.Parse(arr[0]);
            int N = int.Parse(arr[1]);
            int M = int.Parse(arr[2]);

            long total = K * N;

            if (total > M)
            {
                long result = total - M;
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
