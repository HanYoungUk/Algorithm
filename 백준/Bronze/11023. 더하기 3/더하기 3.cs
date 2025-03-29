using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");
            long sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }

            Console.WriteLine(sum);
        }
    }
}