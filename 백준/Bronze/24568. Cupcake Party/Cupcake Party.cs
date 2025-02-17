using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int big = int.Parse(Console.ReadLine());
            int small = int.Parse(Console.ReadLine());

            int bigresult = big * 8;
            int smallresult = small * 3;

            int result = bigresult + smallresult - 28;

            Console.WriteLine(result);
        }
    }
}
