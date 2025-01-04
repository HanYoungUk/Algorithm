using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int result = 0;
            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split("-");

                int x = int.Parse(arr[1]);
                if(x <= 90)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}