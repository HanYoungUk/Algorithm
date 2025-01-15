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
            int num3 = int.Parse(arr[2]);

            if (num1 + num2 == num3)
            {
                Console.WriteLine("correct!");
            }
            else
            {
                Console.WriteLine("wrong!");
            }
        }
    }
}
