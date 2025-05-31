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
                string str = Console.ReadLine();

                if (str == null)
                {
                    break;
                }

                var arr = str.Split(" ");
                int sum = int.Parse(arr[0]) + int.Parse(arr[1]);

                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
