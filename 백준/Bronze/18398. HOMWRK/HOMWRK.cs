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
                int count2 = int.Parse(Console.ReadLine());

                for (int j = 0; j < count2; j++)
                {
                    string str = Console.ReadLine();

                    string[] arr = str.Split(" ");

                    int A = int.Parse(arr[0]);
                    int B = int.Parse(arr[1]);

                    int sum = A + B;
                    long multiple = A * B;
                    sb.AppendLine($"{sum} {multiple}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
