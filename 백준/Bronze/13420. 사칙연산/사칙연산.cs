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
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                long a = long.Parse(arr[0]);
                string b = arr[1];
                long c = long.Parse(arr[2]);
                long d = long.Parse(arr[4]);

                if (b.Equals("+"))
                {
                    long sum = a + c;
                    if(sum == d)
                    {
                        sb.AppendLine("correct");
                    }
                    else
                    {
                        sb.AppendLine("wrong answer");
                    }
                }
                else if (b.Equals("-"))
                {
                    long minus = a - c;
                    if(minus == d)
                    {
                        sb.AppendLine("correct");
                    }
                    else
                    {
                        sb.AppendLine("wrong answer");
                    }
                }
                else if (b.Equals("*"))
                {
                    long multiply = a * c;
                    if(multiply == d)
                    {
                        sb.AppendLine("correct");
                    }
                    else
                    {
                        sb.AppendLine("wrong answer");
                    }
                }
                else
                {
                    long divide = a / c;

                    if (divide == d)
                    {
                        sb.AppendLine("correct");
                    }
                    else
                    {
                        sb.AppendLine("wrong answer");
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
