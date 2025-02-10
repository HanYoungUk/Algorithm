using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 1; i < 46; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    list.Add(i);
                }
            }

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int A = int.Parse(arr[0]) - 1;
            int B = int.Parse(arr[1]) - 1;

            int sum = 0;
            for(int i = A; i <= B; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
