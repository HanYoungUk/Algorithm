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
                // 입력 받음
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");
                sb.Append($"Case #{i}: ");

                for(int j = arr.Length - 1; j >= 0; j--)
                {
                    sb.Append($"{arr[j]} ");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
