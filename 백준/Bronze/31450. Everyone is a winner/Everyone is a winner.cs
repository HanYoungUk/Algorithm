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

            int num1 = int.Parse(arr[0]);
            int num2 = int.Parse(arr[1]);

            if (num1 % num2 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
