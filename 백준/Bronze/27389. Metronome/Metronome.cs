using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            double result = x / 4.0;

            string str = result.ToString();

            if (!str.Contains("."))
            {
                Console.WriteLine(str + ".0");
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
