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
                int N = int.Parse(arr[0]);
                int M = int.Parse(arr[1]);
                int sum = 0;
                for(int j = N; j <= M; j++)
                {
                    string check = j.ToString();
                    int zeroCount = 0;

                    if (check.Contains("0"))
                    {
                        for (int k = 0; k < check.Length; k++)
                        {
                            if (check[k] == '0')
                            {
                                zeroCount++;
                            }
                        }
                        sum += zeroCount;    
                    }
                    else
                    {
                        continue;
                    }
                }
                sb.AppendLine(sum.ToString());
                sum = 0;
            }
            Console.WriteLine(sb.ToString());
                     
        }
    }
}