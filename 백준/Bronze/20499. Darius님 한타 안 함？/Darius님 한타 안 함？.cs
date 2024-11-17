using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              string[] lol = Console.ReadLine().Split("/");

             int kill = int.Parse(lol[0]);
             int death = int.Parse(lol[1]);
             int asist = int.Parse(lol[2]);

             if(kill + asist < death || death == 0)
             {
                 Console.WriteLine("hasu");
             }
             else
             {
                 Console.WriteLine("gosu");
             }
        }
    }
}