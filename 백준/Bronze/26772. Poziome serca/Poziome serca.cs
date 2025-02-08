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

            for (int i = 1; i <= count; i++)
            {
                sb.Append(" @@@   @@@  ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("@   @ @   @ ");
            }
            sb.AppendLine();

            for(int i = 1; i <= count; i++)
            {
                sb.Append("@    @    @ ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("@         @ ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append(" @       @  ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("  @     @   ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("   @   @    ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("    @ @     ");
            }
            sb.AppendLine();
            for (int i = 1; i <= count; i++)
            {
                sb.Append("     @      ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
