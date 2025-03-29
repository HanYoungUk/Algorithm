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

             int total = N * 100;

             if (total >= M)
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
