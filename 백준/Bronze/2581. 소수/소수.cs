using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            // 합과 최소값을 구하는 문제

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j != 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (i == j)
                        {
                            list.Add(i);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            if (list.Count == 0)
            {
                sb.AppendLine("-1");
            }
            else
            {
                sb.AppendLine(sum.ToString());
                sb.AppendLine(list[0].ToString());
            }


            Console.WriteLine(sb.ToString());
        }
    }
}
