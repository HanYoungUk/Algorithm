using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int past = int.Parse(Console.ReadLine());
            int future = int.Parse(Console.ReadLine());

            int result = future - past;

            Console.WriteLine(result);
        }
    }
}
