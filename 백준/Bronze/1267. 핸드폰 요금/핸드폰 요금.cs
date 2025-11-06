using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            List<int> list = new List<int>();

            foreach (var i in arr)
            {
                list.Add(int.Parse(i));
            }

            int Y = 0; // 영식 요금제
            int M = 0; // 민식 요금제

            for (int i = 0; i < list.Count; i++) // 요금제 확인
            {
                if (list[i] % 30 == 0) // 영식 요금제가 나눠질 경우
                {
                    Y += (list[i] / 30 + 1) * 10;
                }
                else // 아닐 경우
                {
                    Y += (list[i] / 30 + 1) * 10;
                }

                if (list[i] % 60 == 0) // 민식 요금제가 나눠질 경우
                {
                    M += (list[i] / 60 + 1) * 15;
                }
                else
                {
                    M += (list[i] / 60 + 1) * 15;
                }
            }

            if (Y == M) // 요금제가 같을 경우
            {
                Console.WriteLine($"Y M {Y}");
            }
            else if (Y > M) // 민식이가 좋은 경우
            {
                Console.WriteLine($"M {M}");
            }
            else
            {
                Console.WriteLine($"Y {Y}");
            }
        }
    }
}