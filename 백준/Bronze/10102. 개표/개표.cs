using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            int A = 0;
            int B = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A')
                {
                    A++;
                }
                else
                {
                    B++;
                }
            }

            if (A > B)
            {
                Console.WriteLine("A");
            }
            else if (A < B)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}
