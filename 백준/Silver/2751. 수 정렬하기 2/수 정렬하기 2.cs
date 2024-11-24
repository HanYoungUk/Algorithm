using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = int.Parse(Console.ReadLine());

             List<int> list = new List<int>();
             for (int i = 0; i < N; i++)
             {
                 int x = int.Parse(Console.ReadLine());

                 list.Add(x);
             }

             list.Sort();

             StringBuilder sb = new StringBuilder();

             foreach (int x in list)
             {
                 sb.AppendLine(x.ToString());
             }
             Console.WriteLine(sb.ToString());        
        }
    }
}