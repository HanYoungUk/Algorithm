using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int x;
             while((x = Int32.Parse(Console.ReadLine())) != -1)
             {
                 if(x < 0)
                 {
                     return;
                 }

                 List<int> list = new List<int>();
                 int sum = 0;
                 for(int i = 1; i <= x; i++)
                 {
                     if(i == x)
                 {
                     break;
                 }
                 if(x % i == 0) // 약수일 경우
                 {
                     sum += i;
                     list.Add(i);
                 }
             }

             if(x == sum)
             {
                 Console.Write(x + " = ");
                 for(int i = 0; i < list.Count; i++)
                 {
                     Console.Write(list[i]);
         
                     if(i == list.Count - 1)
                     {
                         break;
                     }
                     else
                     {
                         Console.Write(" + ");
                     }
                 }
                 Console.WriteLine();
             }
             else
             {
                 Console.WriteLine(x + " is NOT perfect.");
             }
        }
        }
        
    }
}