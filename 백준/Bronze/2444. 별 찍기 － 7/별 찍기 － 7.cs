using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            
            int count = 1;
            for(int i = 1; i <= x; i++)
            {
            // 공백을 만들거
                for(int j = x - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= count; j++)
                {
                    Console.Write("*");
                }
                count = count + 2;
                Console.WriteLine();
            }
            count = count - 4;
            for(int i = 1; i <= x - 1; i++)
            {
                // 공백을 만들거
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= count; j++)
                {
                    Console.Write("*");
                }
                count = count - 2;
                if(i == x - 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}