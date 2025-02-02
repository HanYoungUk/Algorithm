using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");
            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);

            int num = 1;

            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    if (j == y - 1)
                    {
                        sb.Append($"{num++}");
                    }
                    else
                    {
                        sb.Append($"{num++} ");
                    }
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
