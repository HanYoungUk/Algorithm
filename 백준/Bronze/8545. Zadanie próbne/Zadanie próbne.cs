using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reverse = "";

            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Console.WriteLine(reverse);
        }
    }
}
