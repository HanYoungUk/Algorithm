using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;

            for (int i = 0; i < 6; i++)
            {
                string str = Console.ReadLine();

                if (str[0] == 'W')
                {
                    win++;
                }
            }

            if (win >= 5)
            {
                Console.WriteLine(1);
            }
            else if (win == 3 || win == 4)
            {
                Console.WriteLine(2);
            }
            else if (win == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(3);
            }
        }
    }
}
