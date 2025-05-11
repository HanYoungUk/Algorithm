using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int result = 0;

            str = str.Replace("10", ",");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',')
                {
                    result += 10;
                }
                else
                {
                    result += str[i] - '0';
                }
            }

            Console.WriteLine(result);
        }
    }
}
