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

            int N = int.Parse(arr[0]); // 문제 해결 수
            int U = int.Parse(arr[1]); // 유니온 레벨
            int L = int.Parse(arr[2]); // 레벨

            if (N >= 1000)
            {
                if (U >= 8000 || L >= 260)
                {
                    Console.WriteLine("Very Good");
                }
                else
                {
                    Console.WriteLine("Good");
                }                
            }
            else
            {
                Console.WriteLine("Bad");
            }
        }
    }
}
