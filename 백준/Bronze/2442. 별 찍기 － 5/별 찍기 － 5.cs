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

            // 공백이 count - 1부터 시작해야함
            int x = 1;
            for (int i = count; i > 0; i--)
            {
                for (int j = i - 1; j > 0; j--) // 공백용 반복
                {
                    sb.Append(" ");
                }

                for (int j = 0; j < x; j++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
                x = x + 2;
            }


            Console.WriteLine(sb.ToString());
        }
    }
}
