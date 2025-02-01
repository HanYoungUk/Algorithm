using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int now = int.Parse(Console.ReadLine());

            if (now <= limit)
            {
                Console.WriteLine("Congratulations, you are within the speed limit!");
            }
            else if (now - limit <= 20)
            {
                Console.WriteLine("You are speeding and your fine is $100.");
            }
            else if (now - limit >= 31)
            {
                Console.WriteLine("You are speeding and your fine is $500.");
            }
            else
            {
                Console.WriteLine("You are speeding and your fine is $270.");
            }
        }
    }
}
