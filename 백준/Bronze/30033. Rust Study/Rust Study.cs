using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            string str2 = Console.ReadLine();
            string[] arr2 = str2.Split(" ");

            int result = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int num1 = int.Parse(arr[i]);
                int num2 = int.Parse(arr2[i]);

                if (num2 > num1 || num1 == num2)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
