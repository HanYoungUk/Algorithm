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

            // 위에 꺼
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < count * 5; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }
            // 가운데 꺼
            for(int i = 0; i < count * 3; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    sb.Append("@");
                }
                for(int j = 0; j < count * 3; j++)
                {
                    sb.Append(" ");
                }
                for(int j = 0; j < count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }
            // 마지막 거
            for(int i = 0; i < count; i++)
            {
                for (int j = 0; j < count * 5; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}