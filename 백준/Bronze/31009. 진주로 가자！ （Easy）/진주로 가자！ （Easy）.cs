using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int number = int.Parse(Console.ReadLine());

            int jinju = 0; // 진주 비용
            int count = 0; // 진주보다 비싼 비용

            List<int> list = new List<int>(); // 비용들 담을 리스트
            for(int i = 1; i <= number; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");

                string region = arr[0]; // 지역
                int cost = int.Parse(arr[1]); // 경비

                if (region.Equals("jinju"))
                {
                    jinju = cost;
                }

                list.Add(cost);
            }

            foreach(var i in list)
            {
                if(i > jinju)
                {
                    count++;
                }
            }

            Console.WriteLine(jinju);
            Console.WriteLine(count);
        }
    }
}