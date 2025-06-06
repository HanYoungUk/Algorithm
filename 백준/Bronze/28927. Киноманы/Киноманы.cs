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

            str = Console.ReadLine();
            string[] arr2 = str.Split(" ");

            int num1 = int.Parse(arr[0]) * 3;
            int num2 = int.Parse(arr[1]) * 20;
            int num3 = int.Parse(arr[2]) * 120;

            int num4 = int.Parse(arr2[0]) * 3;
            int num5 = int.Parse(arr2[1]) * 20;
            int num6 = int.Parse(arr2[2]) * 120;

            int sum1 = num1 + num2 + num3;
            int sum2 = num4 + num5 + num6;

            if(sum1 > sum2)
            {
                Console.WriteLine("Max");
            }
            else if (sum1 < sum2)
            {
                Console.WriteLine("Mel");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
