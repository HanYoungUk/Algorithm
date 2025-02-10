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

            string a = arr[0];
            string b = arr[1];

            a = a.Replace("5", "6");
            b = b.Replace("5", "6");

            int x = int.Parse(a);
            int y = int.Parse(b);

            int max = x + y;

            a = a.Replace("6", "5");
            b = b.Replace("6", "5");

            x = int.Parse(a);
            y = int.Parse(b);

            int min = x + y;

            Console.WriteLine($"{min} {max}");
        }
    }
}
