using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i = num; i >= 1; i--)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
            
        }
    }
}