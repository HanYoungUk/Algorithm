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

            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);

            string extent = string.Format("{0:F1}", x * y * 0.5);

            Console.WriteLine(extent);
        }
    }
}
