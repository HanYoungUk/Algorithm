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

                if (str.Equals("***"))
                {
                    break;
                }

                string result = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
