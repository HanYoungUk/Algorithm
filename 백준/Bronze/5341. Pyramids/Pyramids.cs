using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> list = new List<int>(); // 결과를 담을 list 선언
            while (true)
            {
                int x = Int32.Parse(Console.ReadLine());

                if (x == 0) break;

                int sum = 0;
                for(int i = 1; i <= x; i++)
                {
                    sum += i;
                }
                list.Add(sum);
            }

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
