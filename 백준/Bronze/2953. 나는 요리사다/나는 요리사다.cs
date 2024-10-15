using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int max = 0; // 최대값 변수
             int turn = 0; // 순서용 변수
             for(int i = 1; i <= 5; i++)
             {
                string[] arr = Console.ReadLine().Split(" ");

                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);
                int c = int.Parse(arr[2]);
                int d = int.Parse(arr[3]);

                int sum = a + b + c + d;

                if(sum > max)
                {
                    max = sum;
                    turn = i;
                }
            }
            Console.Write(turn + " " + max);
             
        }
    }
}