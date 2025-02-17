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

            for(int i = 1; i <= count; i++)
            {
                sb.AppendLine($"Hello World, Judge {i}!");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
