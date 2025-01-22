using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int Red = int.Parse(Console.ReadLine());
            int Green = int.Parse(Console.ReadLine());
            int Blue = int.Parse(Console.ReadLine());

            int sum = (Red * 3) + (Green * 4) + (Blue * 5);

            Console.WriteLine(sum);
        }
    }
}
