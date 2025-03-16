using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int money = int.Parse(Console.ReadLine());

            double one = money * 0.22;
            double two = money * 0.2 * 0.22;

            int num1 = (int)one;
            int num2 = (int)two;

            Console.WriteLine($"{money - num1} {money - num2}");
        }
    }
}
