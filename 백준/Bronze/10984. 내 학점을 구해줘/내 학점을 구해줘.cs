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
                int totalScore = 0;
                double sum = 0;
                for (int j = 0; j < count2; j++)
                {
                    string str = Console.ReadLine();
                    string[] arr = str.Split(" ");

                    totalScore += int.Parse(arr[0]);
                    sum += int.Parse(arr[0]) * double.Parse(arr[1]);
                }
                double result = sum / totalScore;

                sb.AppendLine($"{totalScore} {result:F1}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
