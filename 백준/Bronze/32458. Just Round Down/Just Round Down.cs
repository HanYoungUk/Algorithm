using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            double x = double.Parse(str);
            int value = (int)x;

            Console.WriteLine(value);
        }
    }
}