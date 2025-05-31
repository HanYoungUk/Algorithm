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

            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            long result = 1;

            for (int i = a; i <= b; i++)
            {
                result = result * ((i * i + i) / 2) % 14579;
            }

            Console.WriteLine(result);
        }
    }
}
