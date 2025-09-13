using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int text = int.Parse(Console.ReadLine()); // text 길이

            string original = Console.ReadLine(); // 원본 글
            string modify = Console.ReadLine(); // 고친 글
            int count = 0; // 개수 세기 위한 것

            for(int i = 0; i < original.Length; i++)
            {
                if (original[i] == modify[i])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}