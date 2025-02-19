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

            // N과 C가 주어짐
            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");
                int N = int.Parse(arr[0]);
                int C = int.Parse(arr[1]);

                int result = 0;

                while(N > 0)
                {
                    N = N - C;
                    result++;
                }

                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
