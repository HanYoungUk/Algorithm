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
                int num = int.Parse(Console.ReadLine());

                string str = Console.ReadLine();

                string[] arr = str.Split(" ");
                int sum = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    sum += int.Parse(arr[j]);
                }

                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
