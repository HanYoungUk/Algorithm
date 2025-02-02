using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }

            Array.Sort(arr2);

            Console.WriteLine(arr2[arr2.Length - 1]);
        }
    }
}
