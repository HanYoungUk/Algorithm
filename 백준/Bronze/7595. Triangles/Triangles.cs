using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                for(int i = 0; i < num; i++)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        sb.Append("*");
                    }
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
