using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int one = 0; // 첫번째 더하기만 한거
            int two = 1; // 다 더한다음에 제곱
            int three = 0; // 다 세제곱하고 더한거
            List<int> list = new List<int>();
            for(int i = 1; i<= N; i++) 
            {
                one += i;
                list.Add(i * i * i);
            }

            two = one * one;

            foreach(int i in list)
            {
                three += i;
            }

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);        
        }
    }
}