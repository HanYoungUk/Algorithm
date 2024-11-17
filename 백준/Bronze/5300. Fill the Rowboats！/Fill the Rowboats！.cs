using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int count = 0; 
            for(int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
                count++;
                if (i == num && count < 6)
                {
                    Console.Write("Go!");
                    break;
                }
                if (count == 6)
                {
                    Console.Write("Go! ");
                    count = 0;
                }
            }
        }
    }
}