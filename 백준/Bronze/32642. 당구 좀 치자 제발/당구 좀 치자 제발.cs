using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int result = 0;
            long realResult = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals("0"))
                {
                    result--;
                }
                else
                {
                    result++;
                }

                realResult += result;
            }

            Console.WriteLine(realResult);
        }
    }
}
