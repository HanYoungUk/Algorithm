using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] arr = Console.ReadLine().Split(" ");

             int sum = 0;
             for(int i = 0; i < arr.Length; i++)
             {
                 int x = int.Parse(arr[i]);

                 sum += x * x;
             }

             Console.WriteLine(sum % 10);       
        }
    }
}