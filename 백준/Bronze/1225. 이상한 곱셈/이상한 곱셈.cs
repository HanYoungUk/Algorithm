using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            long sum = 0;
            string str1 = arr[0];
            string str2 = arr[1];
            
            for(int i = 0; i < str1.Length; i++)
            {
                int num = str1[i] - '0';

                for(int j = 0; j < str2.Length; j++)
                {
                    int num2 = str2[j] - '0';
                    long multy = num * num2;
                    sum += multy;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
