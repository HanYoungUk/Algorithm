using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());

            int v = num / 5;
            int i = num % 5;

            for (int k = 0; k < v; k++)
            {
                sb.Append("V");
            }
            for (int k = 0; k < i; k++)
            {
                sb.Append("I");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
