using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (arr[i - 1].Equals($"{i}"))
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
