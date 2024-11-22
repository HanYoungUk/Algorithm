using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int lion = 0;
            int tiger = 0;

             for(int i = 0; i < 9; i++)
             {
                 string vote = Console.ReadLine();

                 if (vote.Equals("Lion"))
                 {
                     lion++;
                 }
                 else if (vote.Equals("Tiger"))
                 {
                     tiger++;
                 }
             }
             if(lion > tiger)
             {
                 Console.WriteLine("Lion");
             }
             else
             {
                 Console.WriteLine("Tiger");
             }
        }
    }
}