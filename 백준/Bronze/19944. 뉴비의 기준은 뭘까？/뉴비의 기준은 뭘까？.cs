using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int N = int.Parse(arr[0]);
            int M = int.Parse(arr[1]);

            if(M == 1 || M == 2)
            {
                Console.WriteLine("NEWBIE!");
            }
            else if (N >= M)
            {
                Console.WriteLine("OLDBIE!");
            }
            else
            {
                Console.WriteLine("TLE!");
            }
        }
    }
}
