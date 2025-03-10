using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.Replace("pi", ",").Replace("ka", ",").Replace("chu", ",");

            str = str.Replace(",", "");
            
            if (str.Length == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
