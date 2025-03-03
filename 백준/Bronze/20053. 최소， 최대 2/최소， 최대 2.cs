using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();

             int count = int.Parse(Console.ReadLine());

             for(int i = 0; i < count; i++)
             {
                 int numcount = int.Parse(Console.ReadLine());

                 string str = Console.ReadLine();
                 string[] arr = str.Split(" ");

                 List<int> list = new List<int>();

                 foreach(var j in arr)
                 {
                     list.Add(int.Parse(j));
                 }
                 list.Sort();

                 int max = list[list.Count - 1];
                 int min = list[0];

                 sb.AppendLine($"{min} {max}");
             }
             Console.WriteLine(sb.ToString());
        }
    }
}
