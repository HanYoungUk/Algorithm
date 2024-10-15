using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              string ch = Console.ReadLine();

             if(ch.Equals("N") || ch.Equals("n"))
             {
                 Console.WriteLine("Naver D2");
             }
             else
             {
                 Console.WriteLine("Naver Whale");
             }
        }
    }
}