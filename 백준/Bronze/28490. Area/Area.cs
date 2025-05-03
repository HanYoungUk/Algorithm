using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());

            int max = Int32.MinValue;

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int total = int.Parse(arr[0]) * int.Parse(arr[1]);

                if(total > max)
                {
                    max = total;
                }
            }

            Console.WriteLine(max);
        }
    }
}
