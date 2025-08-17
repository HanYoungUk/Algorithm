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

            int N = int.Parse(arr[0]);
            int M = int.Parse(arr[1]);
            HashSet<string> list = new HashSet<string>(); // 기존 문자열

            int count = 0;

            for(int i = 0; i < N; i++)
            {
                list.Add(Console.ReadLine());
            }

            for (int i = 0; i < M; i++)
            {
                string ss = Console.ReadLine();

                if (list.Contains(ss))
                {
                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
}
