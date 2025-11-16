using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string str = Console.ReadLine();

            string result = str.Substring(str.Length - 5, 5);

            Console.WriteLine(result);
        }
    }
}
