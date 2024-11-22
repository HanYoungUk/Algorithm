using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int a = 0; // y가 모음이 아닐 때
            int b = 0; // y가 모음이 맞을 때
            for(int i = 0; i < str.Length; i++) 
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    a++;
                }
                if (str[i] == 'y')
                {
                    b++;
                }
            }
            b = a + b;

            Console.WriteLine(a + " " + b);
        }
    }
}