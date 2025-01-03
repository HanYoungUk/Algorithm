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
                int g = 0;
                int b = 0;

                for(int j = 0; j < str.Length; j++)
                {
                    if (str[j] == 'g' || str[j] == 'G')
                    {
                        g++;
                    }
                    else if (str[j] == 'b' || str[j] == 'B')
                    {
                        b++;
                    }
                }

            if(g < b)
            {
                sb.AppendLine($"{str} is A BADDY");
            }
            else if(g == b)
            {
                sb.AppendLine($"{str} is NEUTRAL");
            }
            else
            {
                sb.AppendLine($"{str} is GOOD");
            }
        }
        Console.WriteLine(sb.ToString());
        }
    }
}
