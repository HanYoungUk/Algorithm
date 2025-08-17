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
            int sum = 0;
            foreach (var i in arr)
            {
                sum += int.Parse(i);
            }

            Console.WriteLine(sum * 5);
        }
    }
}
