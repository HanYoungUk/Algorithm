using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 진호의 mbti
            string mbti1 = Console.ReadLine();

            // 친구의 수
            int friends = int.Parse(Console.ReadLine());

            int count = 0; // 결과 값
            for (int i = 0; i < friends; i++)
            {
                // 친구들 mbti
                string mbti2 = Console.ReadLine();

                if (mbti1.Equals(mbti2))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
