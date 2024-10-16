using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
             while (true)
             {
                 int x = Int32.Parse(Console.ReadLine());

                 if(x == -1)
                 {
                     break;
                 }

                 sum += x;
             }

             Console.WriteLine(sum);
            
        }
    }
}