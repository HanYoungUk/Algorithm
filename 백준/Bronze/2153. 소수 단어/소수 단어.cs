using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int num = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                dic.Add(i, num++);
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                dic.Add(i, num++);
            }

            string str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += dic[str[i]];
            }

            if (sum == 1)
            {
                Console.WriteLine("It is a prime word.");
                return;
            }
            for (int i = 2; i <= sum; i++)
            {
                if (sum % i != 0)
                {
                    continue;
                }
                else
                {
                    if (sum == i)
                    {
                        sb.AppendLine("It is a prime word.");
                    }
                    else
                    {
                        sb.AppendLine("It is not a prime word.");
                        break;

                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
