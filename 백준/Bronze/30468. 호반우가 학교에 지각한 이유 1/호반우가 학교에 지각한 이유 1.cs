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

            int STR = int.Parse(arr[0]);
            int DEX = int.Parse(arr[1]);
            int INT = int.Parse(arr[2]);
            int LUK = int.Parse(arr[3]);

            int N = int.Parse(arr[4]);

            // N * 4 == 총합

            int sum = STR + DEX + INT + LUK;
            int x = N * 4;

            int result = x - sum;
            if(result <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
