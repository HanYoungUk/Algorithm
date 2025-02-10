using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            double sum = 0;

            for(int i = 0; i < str.Length; i++)
            {
                sum += Math.Pow(str[i] - '0' ,5);
            }
            Console.WriteLine(sum);
        }
    }
}
