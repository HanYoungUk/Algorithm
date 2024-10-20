using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int s = Int32.Parse(Console.ReadLine());
             int m = Int32.Parse(Console.ReadLine());
             int l = Int32.Parse(Console.ReadLine());

             int x = (1 * s) + (2 * m) + (3 * l);

             if(x >= 10)
             {
                 Console.WriteLine("happy");
             }
             else
             {
                 Console.WriteLine("sad");
             }
        }
    }
}