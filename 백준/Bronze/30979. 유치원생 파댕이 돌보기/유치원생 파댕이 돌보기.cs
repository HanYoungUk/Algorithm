using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int minute = int.Parse(Console.ReadLine());

            int candy = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }

            if(sum >= minute)
            {
                Console.WriteLine("Padaeng_i Happy");
            }
            else
            {
                Console.WriteLine("Padaeng_i Cry");
            }
        }
    }
}
