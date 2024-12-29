using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
           string word = Console.ReadLine();
           word = word.Trim();
           string[] arr = word.Split(" ");

              if (arr[0].Length == 0)
              {
                  Console.WriteLine(0);
                  return;
              }
            
           Console.WriteLine(arr.Length);
            
        }
    }
}