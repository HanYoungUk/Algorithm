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
                for (int j = 0; j < count * 5; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count * 5; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            for (int i = 0; i < count * 2; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
