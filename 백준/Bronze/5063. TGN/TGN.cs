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

                int r = int.Parse(arr[0]);
                int e = int.Parse(arr[1]);
                int c = int.Parse(arr[2]);

                if (e - c > r)
                {
                    sb.AppendLine("advertise");
                }
                else if (e - c == r)
                {
                    sb.AppendLine("does not matter");
                }
                else
                {
                    sb.AppendLine("do not advertise");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
