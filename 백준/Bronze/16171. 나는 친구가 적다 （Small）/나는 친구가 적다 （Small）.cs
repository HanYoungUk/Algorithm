using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string original = Console.ReadLine();

            string s = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57) // 숫자일경우 넘어감
                {
                    continue;
                }
                else
                {
                    s += str[i];
                }
            }

            if (s.Contains(original))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
