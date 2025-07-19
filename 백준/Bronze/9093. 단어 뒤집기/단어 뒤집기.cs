using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                foreach (var ar in arr) // 공백을 기준으로 나눠진 요소들을 다 봄
                {
                    for (int j = ar.Length - 1; j >= 0; j--) // 역순으로 돌게
                    {
                        sb.Append(ar[j]);
                    }
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
