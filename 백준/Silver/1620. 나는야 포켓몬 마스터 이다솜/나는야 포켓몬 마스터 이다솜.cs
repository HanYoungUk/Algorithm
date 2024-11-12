using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); // 포켓몬의 개수 N이랑 문제의 개수 M
            string[] arr = str.Split(" "); // 공백을 기준으로 나눔
            int num = Int32.Parse(arr[0]); // 도감의 개수
            int solve = Int32.Parse(arr[1]); // 맞춰야할 문제 수

            Dictionary<string, int> dic= new Dictionary<string, int>(); // 도감용 딕셔너리
            Dictionary<int, string> dic2 = new Dictionary<int, string>();
            for(int i = 1; i <= num; i++)
            {

                string poketmon = Console.ReadLine();

                dic.Add(poketmon, i);
                dic2.Add(i, poketmon);
            }

            // 출력용 만들기

            for(int i = 0; i < solve; i++)
            {
                string resolve = Console.ReadLine();

                if (dic.ContainsKey(resolve))
                {
                    Console.WriteLine(dic[resolve]);
                }
                else if (dic2.ContainsKey(Int32.Parse(resolve)))
                {
                    Console.WriteLine(dic2[Int32.Parse(resolve)]);
                }
            }
        }
    }
}