using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            var sum = num1 + num2 + num3 <= 21 ? 1 : 0;
            Console.WriteLine(sum);
        }
    }
}
