using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int happy = 0;
            int sad = 0;

            string str = Console.ReadLine();

            str = str.Replace(":-)", "1").Replace(":-(","2");

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                {
                    happy++;
                }
                else if (str[i] == '2')
                {
                    sad++;
                }
            }

            if (happy > sad)
            {
                Console.WriteLine("happy");
            }
            else if (sad > happy)
            {
                Console.WriteLine("sad");
            }
            else if (happy != 0 && happy == sad)
            {
                Console.WriteLine("unsure");
            }
            else
            {
                Console.WriteLine("none");
            }
        }
    }
}
