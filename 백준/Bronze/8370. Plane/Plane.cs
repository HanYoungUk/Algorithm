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

            int num = int.Parse(arr[1]) * int.Parse(arr[0]);
            int num2 = int.Parse(arr[2]) * int.Parse(arr[3]);

            int result = num + num2;
            Console.WriteLine(result);
        }
    }
}
