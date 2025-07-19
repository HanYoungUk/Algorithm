using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string str = Console.ReadLine().ToLower();

                if (str.Equals("#")) // 멈춤
                {
                    break;
                }

                string[] arr = str.Split(" ");

                char check = arr[0][0];

                int count = 0;
                for (int i = 1; i < arr.Length; i++) // 첫번째 항부터 봄
                {
                    for (int j = 0; j < arr[i].Length; j++) // 각요소들을 훑음
                    {
                        if (arr[i][j] == check) // 같을 경우
                        {
                            count++;
                        }
                    }
                }

                sb.AppendLine($"{check} {count}");

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
