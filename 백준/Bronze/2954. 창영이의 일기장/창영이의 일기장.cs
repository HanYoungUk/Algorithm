using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string answer = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    answer += str[i];
                    i += 2;
                }
                else
                {
                    answer += str[i];
                }
            }
            Console.WriteLine(answer);
        }
    }
}