using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int result = 0;
            if (length % 5 == 0)
            {
                result = length / 5;
                Console.WriteLine(result);
            }
            else
            {
                result = length / 5 + 1;
                Console.WriteLine(result);
            }
        }
    }
}
