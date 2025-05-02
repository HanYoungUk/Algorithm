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

            int x = int.Parse(arr[0]) * int.Parse(arr[1]);

            int y = int.Parse(arr[2]) * int.Parse(arr[3]) * int.Parse(arr[4]);

            Console.WriteLine(x - y);
        }
    }
}
