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

                string binary = Console.ReadLine().Trim();

                long result = Convert.ToInt64(binary, 2);

                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
