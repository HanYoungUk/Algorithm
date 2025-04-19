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
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");
                long sum = 0;
                foreach(var j in arr)
                {
                    sum += int.Parse(j);
                }
                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
