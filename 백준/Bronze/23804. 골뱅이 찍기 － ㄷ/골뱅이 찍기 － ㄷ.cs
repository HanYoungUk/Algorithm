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

            // 첫번째
            for(int i = 0; i < count; i++)
            {
                for(int j = 0; j < 5 * count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            // 두번째
            for(int i = 0; i < count * 3; i++)
            {
                for(int j = 0; j < count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            // 세번째
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < 5 * count; j++)
                {
                    sb.Append("@");
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
