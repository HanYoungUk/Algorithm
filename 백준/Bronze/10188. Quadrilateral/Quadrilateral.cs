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

                int x = int.Parse(arr[0]);
                int y = int.Parse(arr[1]);

                for (int a = 0; a < y; a++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        sb.Append("X");
                    }
                    sb.AppendLine();
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
