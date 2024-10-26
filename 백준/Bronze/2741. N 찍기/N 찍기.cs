using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i = 1; i <= x; i++)
            {
                sb.AppendLine(i.ToString());   
            }
            Console.WriteLine(sb);
        }
    }
}