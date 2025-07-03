using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int score = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals("1"))
                {
                    score++;
                }
                else
                {
                    score = 0;
                }
                sum += score;

            }
            Console.WriteLine(sum);
        }
    }
}
