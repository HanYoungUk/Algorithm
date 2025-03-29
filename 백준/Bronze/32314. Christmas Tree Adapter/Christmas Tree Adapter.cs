using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine()); // 암페어의 개수
            string[] arr = Console.ReadLine().Split(" "); // 어탭더들

            int candidate = int.Parse(arr[0]); // 후보 어대텁의 와트
            int bolt = int.Parse(arr[1]); // 볼트

            int result = candidate / bolt; // 계산식

            if(result >= count)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}