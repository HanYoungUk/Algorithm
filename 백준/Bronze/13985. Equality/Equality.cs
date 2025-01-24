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
            int b = int.Parse(arr[2]);
            int c = int.Parse(arr[4]);

            if (a + b == c)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
