using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int approved = 0;
            int rejected = 0;
            int invalid = 0;

            foreach (var i in arr)
            {
                if (i.Equals("1"))
                {
                    approved++;
                }
                else if (i.Equals("-1"))
                {
                    rejected++;
                }
                else
                {
                    invalid++;
                }
            }

            if (total % 2 == 0) // 짝수일 경우
            {
                if (invalid >= total / 2)
                {
                    Console.WriteLine("INVALID");
                    return;
                }

            }
            else // 홀수일 경우
            {
                if (invalid >= total / 2 + 1)
                {
                    Console.WriteLine("INVALID");
                    return;
                }
            }

            if (rejected >= approved) // 통과 못함
            {
                Console.WriteLine("REJECTED");
            }
            else
            {
                Console.WriteLine("APPROVED");
            }
        }
    }
}
