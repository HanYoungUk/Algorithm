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

            int result = 0;

            if(num1 == 1 || num1 == 3)
            {
                result++;
            }
            if(num2 == 6 || num2 == 8)
            {
                result++;
            }
            if(num3 == 2 || num3 == 5)
            {
                result++;
            }

            if (result == 3)
            {
                Console.WriteLine("JAH");
            }
            else
            {
                Console.WriteLine("EI");
            }
        }
    }
}
