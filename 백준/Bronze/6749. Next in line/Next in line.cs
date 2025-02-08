using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int child1 = int.Parse(Console.ReadLine());
            int child2 = int.Parse(Console.ReadLine());

            int minus = child2 - child1;

            int result = child2 + minus;

            Console.WriteLine(result);
        }
    }
}
