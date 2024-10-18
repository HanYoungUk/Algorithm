using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> list = new List<int>();
             while (true)
             {
                 string x = Console.ReadLine();

                 if (x.Equals("#"))
                 {
                     break;
                 }

                 x = x.ToLower();
                 int count = 0;
                 for(int i = 0; i < x.Length; i++)
                 {
                     if(x[i] == 'a' || x[i] == 'e' || x[i] == 'i' || x[i] == 'o' || x[i] == 'u')
                     {
                         count++;
                     }
                 }
                 list.Add(count);
             }

             foreach (int i in list) 
             { 
                 Console.WriteLine(i);
             }     
        }
    }
}