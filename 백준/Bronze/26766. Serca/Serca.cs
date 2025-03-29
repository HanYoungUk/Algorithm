using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());
             StringBuilder sb = new StringBuilder();

             for(int i = 0; i < count; i++)
             {
                 sb.AppendLine(" @@@   @@@ ");
                 sb.AppendLine("@   @ @   @");
                 sb.AppendLine("@    @    @");
                 sb.AppendLine("@         @");
                 sb.AppendLine(" @       @ ");
                 sb.AppendLine("  @     @  ");
                 sb.AppendLine("   @   @   ");
                 sb.AppendLine("    @ @    ");
                 sb.AppendLine("     @     ");
             }
             Console.WriteLine(sb.ToString());
        }
    }
}