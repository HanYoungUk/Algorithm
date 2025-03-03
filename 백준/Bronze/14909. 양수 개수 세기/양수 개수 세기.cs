using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            
             string str = Console.ReadLine();
             string[] arr = str.Split(" ");
             int count = 0;

             foreach (var i in arr)
             {
                 int num = int.Parse(i);

                 if(num > 0)
                 {
                     count++;
                 }
             }

             Console.WriteLine(count);
        }
    }
}
