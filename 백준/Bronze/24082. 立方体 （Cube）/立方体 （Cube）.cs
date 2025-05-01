using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            long x = num * num * num;

            Console.WriteLine(x);
        }
    }
}
