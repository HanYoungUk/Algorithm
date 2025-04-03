using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int result = 0;
                int count = 0;
                string str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == 'U')
                    {
                        count++;
                        if (j == str.Length - 1)
                        {
                            result += count;
                        }
                    }
                    else if (str[j] == 'D')
                    {
                        result += count;
                        break;
                    }
                }

                sb.AppendLine(result.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
