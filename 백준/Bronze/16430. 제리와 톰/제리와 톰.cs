using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int child = int.Parse(arr[0]);
            int parent = int.Parse(arr[1]);

            Console.WriteLine($"{parent - child} {parent}");
        }
    }
}