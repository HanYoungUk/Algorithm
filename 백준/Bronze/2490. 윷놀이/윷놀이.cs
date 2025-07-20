using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int result = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (0 == int.Parse(arr[j]))
                    {
                        result++;
                    }
                }
                if (result == 4) // 윳
                {
                    sb.AppendLine("D");
                }
                else if (result == 3)
                {
                    sb.AppendLine("C");
                }
                else if (result == 2)
                {
                    sb.AppendLine("B");
                }
                else if (result == 1)
                {
                    sb.AppendLine("A");
                }
                else
                {
                    sb.AppendLine("E");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
