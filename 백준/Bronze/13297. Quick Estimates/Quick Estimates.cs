using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine()); // 횟수용
            List<int> list = new List<int>(); // 출력용 리스트

            for(int i = 0; i < num; i++)
            {
                string str = Console.ReadLine(); // 비용을 받음

                int x = str.Length;

                list.Add(x);
            }

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}