using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for(int i = 0; i < 5; i++)
            {
                int score = int.Parse(Console.ReadLine());

                total += score;
            }
            Console.WriteLine(total);
        }
    }
}
