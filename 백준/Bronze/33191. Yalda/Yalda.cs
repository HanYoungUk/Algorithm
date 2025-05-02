using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = int.Parse(Console.ReadLine());

            int watermelon = int.Parse(Console.ReadLine());
            int pomegranates = int.Parse(Console.ReadLine());
            int nuts = int.Parse(Console.ReadLine());

            if (cash >= watermelon)
            {
                Console.WriteLine("Watermelon");
                return;
            }
            if (cash >= pomegranates)
            {
                Console.WriteLine("Pomegranates");
                return;
            }
            if (cash >= nuts)
            {
                Console.WriteLine("Nuts");
                return;
            }
            else
            {
                Console.WriteLine("Nothing");

            }
        }
    }
}
