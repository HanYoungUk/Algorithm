using System;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();
            for(int i = 0; i < N; i++)
            {
                BigInteger x = BigInteger.Parse(Console.ReadLine());

                if(x % 2 == 0) // 짝수일 경우
                {
                    list.Add("even");
                }
                else // 홀수일 경우
                {
                    list.Add("odd");
                }
            }

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }       
        }
    }
}