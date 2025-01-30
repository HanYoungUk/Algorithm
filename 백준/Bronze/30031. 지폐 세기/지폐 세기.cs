using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int s = int.Parse(arr[0]);

                if (s == 136)
                {
                    sum += 1000;
                }
                else if (s == 142)
                {
                    sum += 5000;
                }
                else if (s == 148)
                {
                    sum += 10000;
                }
                else if (s == 154)
                {
                    sum += 50000;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
