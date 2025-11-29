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
                string str = Console.ReadLine();

                if (str.Equals("0"))
                {
                    break;
                }

                int num = int.Parse(str);

                while (num >= 10)
                {
                    string str2 = num.ToString();
                    int sum = 0;

                    for (int i = 0; i < str2.Length; i++)
                    {
                        sum += str2[i] - '0';
                    }

                    num = sum;
                }

                sb.AppendLine(num.ToString());

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
