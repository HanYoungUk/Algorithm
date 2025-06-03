using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int result = 0;

            while (str.Length > 1)
            {
                int x = 1;
                for (int i = 0; i < str.Length; i++)
                {
                    x *= str[i] - '0';
                }
                str = x.ToString();


                result++;
            }

            Console.WriteLine(result);
        }
    }
}
