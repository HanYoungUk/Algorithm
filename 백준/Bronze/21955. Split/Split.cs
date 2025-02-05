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

            int half = str.Length / 2;

            sb.Append(str.Substring(0, half) + " ");

            sb.Append(str.Substring(half, half));

            Console.WriteLine(sb.ToString());
        }
    }
}
