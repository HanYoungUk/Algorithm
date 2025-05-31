using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();

            // 최대 공약수 최소 공배수

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);

                int max = 0; // 최대 공약수
                int min = 0; // 최소 공배수

                if (a > b)
                {
                    for (int j = b; j >= 1; j--)
                    {
                        if (a % j == 0 && b % j == 0)
                        {
                            max = j;
                            break;
                        }
                    }
                    min = (a / max) * (b / max) * max;

                }
                else
                {
                    for (int j = a; j >= 1; j--)
                    {
                        if (a % j == 0 && b % j == 0)
                        {
                            max = j;
                            break;
                        }
                    }
                    min = (a / max) * (b / max) * max;
                }

                sb.AppendLine(min + " " + max);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
