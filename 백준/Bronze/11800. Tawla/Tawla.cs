using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "Yakk");
            dic.Add(2, "Doh");
            dic.Add(3, "Seh");
            dic.Add(4, "Ghar");
            dic.Add(5, "Bang");
            dic.Add(6, "Sheesh");

            int count = int.Parse(Console.ReadLine());

            for(int i = 1; i <= count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int num1 = int.Parse(arr[0]);
                int num2 = int.Parse(arr[1]);

                if(num1 == num2)
                {
                    if (num1 == 1)
                    {
                        sb.AppendLine($"Case {i}: Habb Yakk");
                    }
                    else if (num1 == 2)
                    {
                        sb.AppendLine($"Case {i}: Dobara");
                    }
                    else if (num1 == 3)
                    {
                        sb.AppendLine($"Case {i}: Dousa");
                    }
                    else if (num1 == 4)
                    {
                        sb.AppendLine($"Case {i}: Dorgy");
                    }
                    else if (num1 == 5)
                    {
                        sb.AppendLine($"Case {i}: Dabash");
                    }
                    else if (num1 == 6)
                    {
                        sb.AppendLine($"Case {i}: Dosh");
                    }
                }
                else if(num1 > num2)
                {
                    if(num1 == 6 && num2 == 5)
                    {
                        sb.AppendLine($"Case {i}: Sheesh Beesh");
                        continue;
                    }
                    else
                    {
                        sb.AppendLine($"Case {i}: {dic[num1]} {dic[num2]}");
                    }
                }
                else if(num2 > num1)
                {
                    if (num1 == 5 && num2 == 6)
                    {
                        sb.AppendLine($"Case {i}: Sheesh Beesh");
                        continue;
                    }
                    else
                    {
                        sb.AppendLine($"Case {i}: {dic[num2]} {dic[num1]}");
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
