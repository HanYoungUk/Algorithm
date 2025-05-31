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
                string[] arr = str.Split(",");

                int sum = int.Parse(arr[0]) + int.Parse(arr[1]);
                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
