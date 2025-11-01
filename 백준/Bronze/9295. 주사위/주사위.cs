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

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int num1 = int.Parse(arr[0]);
                int num2 = int.Parse(arr[1]);

                sb.AppendLine($"Case {i + 1}: {num1 + num2}");

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
