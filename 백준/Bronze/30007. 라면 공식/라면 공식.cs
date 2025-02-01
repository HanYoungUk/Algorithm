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

                int A = int.Parse(arr[0]);
                int B = int.Parse(arr[1]);
                int X = int.Parse(arr[2]);

                int result = A * (X - 1) + B;

                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
