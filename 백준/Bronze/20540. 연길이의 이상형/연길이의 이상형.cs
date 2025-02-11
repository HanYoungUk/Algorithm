using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'E')
                {
                    sb.Append("I");
                }
                else if (str[i] == 'I')
                {
                    sb.Append("E");
                }
                else if (str[i] == 'S')
                {
                    sb.Append("N");
                }
                else if (str[i] == 'N')
                {
                    sb.Append("S");
                }
                else if (str[i] == 'F')
                {
                    sb.Append("T");
                }
                else if (str[i] == 'T')
                {
                    sb.Append("F");
                }
                else if (str[i] == 'P')
                {
                    sb.Append("J");
                }
                else if(str[i] == 'J')
                {
                    sb.Append("P");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
