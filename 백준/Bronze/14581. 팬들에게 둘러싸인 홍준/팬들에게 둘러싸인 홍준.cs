using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string id = Console.ReadLine();

            sb.AppendLine(":fan::fan::fan:");
            sb.AppendLine($":fan::{id}::fan:");
            sb.AppendLine(":fan::fan::fan:");

            Console.WriteLine(sb.ToString());
        }
    }
}
