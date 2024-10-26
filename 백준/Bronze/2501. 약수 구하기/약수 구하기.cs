using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            string[] arr = x.Split(" ");

            int first = Int32.Parse(arr[0]);
            int second = Int32.Parse(arr[1]);

            int count = 1;
            for(int i = 1; i <= first; i++)
            {
                if(first % i == 0) // 약수일 경우
            {
                if(count == second)
                {
                    Console.WriteLine(i);
                    break;
                }
                if(i == first)
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
        }

        if(count < second)
        {
            Console.WriteLine(0);
        }
        }
    }
}