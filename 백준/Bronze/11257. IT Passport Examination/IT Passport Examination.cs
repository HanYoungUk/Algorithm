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

                int S = int.Parse(arr[1]);
                int I = int.Parse(arr[2]);
                int T = int.Parse(arr[3]);
                int sum = S + I + T;
                if (sum >= 55) // 총점이 55점이상을 받아야함.
                {
                    if (S >= 11 && I >= 8 && T >= 12)
                    {
                        sb.AppendLine($"{arr[0]} {sum} PASS");
                    }
                    else
                    {
                        sb.AppendLine($"{arr[0]} {sum} FAIL");
                    }
                }
                else
                {
                    sb.AppendLine($"{arr[0]} {sum} FAIL");
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
