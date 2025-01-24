using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = int.Parse(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine(0);
            }
            else
            {
                int result = cash / 5;

                Console.WriteLine(result);
            }
        }
    }
}
