using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             List<int> scores = new List<int>();
            int sum = 0; // 합계용

            for(int i = 0; i < 5; i++)
            {
                int score = int.Parse(Console.ReadLine());

                scores.Add(score);
            }

            for(int i =0; i < scores.Count; i++)
            {
                if (scores[i] < 40)
                {
                    sum += 40;
                }
                else
                {
                    sum += scores[i];
                }
            }
            Console.WriteLine(sum / 5);
        }
    }
}