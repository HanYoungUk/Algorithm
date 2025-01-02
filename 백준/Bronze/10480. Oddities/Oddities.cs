using System;
using System.Text;
namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = int.Parse(Console.ReadLine());
             StringBuilder sb = new StringBuilder();

             for(int i = 0; i < N; i++)
             {
                 int x = int.Parse(Console.ReadLine());

                 if(x % 2 == 0)
                 {
                     sb.AppendLine($"{x} is even");
                 }
                 else
                 {
                     sb.AppendLine($"{x} is odd");
                 }
             }

             Console.WriteLine(sb.ToString());
        }
    }
}