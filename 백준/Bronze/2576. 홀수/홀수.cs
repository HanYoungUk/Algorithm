using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> list = new List<int>(); // 최소값을 구할 리스트
            for(int i = 1; i <= 7; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if(x % 2 == 1) // 홀수 일 경우
                {
                    sum += x;
                    list.Add(x);
                }
            }
            list.Sort(); // 오름차순 정렬

            if (list.Count > 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine(list[0]);
            }
            else
            {
                Console.WriteLine(-1);
            }     
        }
    }
}