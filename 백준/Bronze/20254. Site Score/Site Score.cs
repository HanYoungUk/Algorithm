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

            int U = int.Parse(arr[0]);
            int T = int.Parse(arr[1]);
            int O = int.Parse(arr[2]);
            int O2 = int.Parse(arr[3]);

            long result = (U * 56) + (24 * T) + (14 * O) + (6 * O2);

            Console.WriteLine(result);
        }
    }
}
