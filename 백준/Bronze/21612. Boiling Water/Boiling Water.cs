using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int temperature = int.Parse(Console.ReadLine());

            int P = 5 * temperature - 400;

            sb.AppendLine(P.ToString());

            if (P > 100)
            {
                sb.AppendLine("-1");
            }
            else if (P == 100)
            {
                sb.AppendLine("0");
            }
            else
            {
                sb.AppendLine("1");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
