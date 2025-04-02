using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             // 횟수
             int count = int.Parse(Console.ReadLine());
             StringBuilder sb = new StringBuilder();

             for(int i = 0; i < count; i++)
             {
                 string str = Console.ReadLine();

                 string[] arr = str.Split(" ");
                 int a = int.Parse(arr[0]);
                 int b = int.Parse(arr[1]);

                 if(b > a)
                 {
                     sb.AppendLine("NO BRAINS");
                 }
                 else
                 {
                     sb.AppendLine("MMM BRAINS");
                 }
             }

             Console.WriteLine(sb.ToString());
        }
    }
}
