using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            long A = int.Parse(arr[0]);
            long B = int.Parse(arr[1]);

            long result = (A + B) * (A - B);

            Console.WriteLine(result);
        }
    }
}
