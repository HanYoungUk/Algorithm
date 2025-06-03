using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int human = int.Parse(arr[0]);
            int extent = int.Parse(arr[1]);
            int total = human * extent;

            str = Console.ReadLine();

            string[] arr2 = str.Split(" ");

            for (int i = 0; i < arr2.Length; i++)
            {
                int x = int.Parse(arr2[i]);

                sb.Append(x - total + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
