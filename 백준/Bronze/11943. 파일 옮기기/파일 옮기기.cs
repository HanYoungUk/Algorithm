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

            int x1 = int.Parse(arr[0]);
            int y1 = int.Parse(arr[1]);

            string str2 = Console.ReadLine();

            string[] arr2 = str2.Split(" ");

            int x2 = int.Parse(arr2[0]);
            int y2 = int.Parse(arr2[1]);


            if (x1 + y2 > x2 + y1)
            {
                Console.WriteLine(x2 + y1);
            }
            else
            {
                Console.WriteLine(x1 + y2);
            }
        }
    }
}
