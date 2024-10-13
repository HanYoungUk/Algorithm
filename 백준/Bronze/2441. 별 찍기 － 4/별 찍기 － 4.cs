using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = Int32.Parse(Console.ReadLine());

            int x = 0; // 공백용 변수
            for(int i = count; i >= 1; i--)
            {
                if(x > 0)
                {
                    for(int j = 0; j < x; j++)
                    {
                        Console.Write(" ");
                    }
                    for(int k = 0; k < i; k++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
                x++;
            }
        }
    }
}