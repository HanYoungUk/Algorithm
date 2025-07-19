using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine(); // 그냥 받을거

            string str = Console.ReadLine(); // s를 받음

            int two = 0; // 2를 받을 변수
            int e = 0; // e를 받을 변수

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '2')
                {
                    two++;
                }
                else
                {
                    e++;
                }
            }

            if (two > e) // 2가 더많은 경우
            {
                Console.WriteLine(2);
            }
            else if (e > two) // e가 많은 경우
            {
                Console.WriteLine("e");
            }
            else
            {
                Console.WriteLine("yee");
            }
        }
    }
}
