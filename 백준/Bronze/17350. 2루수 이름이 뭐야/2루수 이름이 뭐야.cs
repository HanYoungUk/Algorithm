using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());

            bool check = false;

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals("anj"))
                {
                    check = true;
                }
            }

            if (check)
            {
                Console.WriteLine("뭐야;");
            }
            else
            {
                Console.WriteLine("뭐야?");
            }
        }
    }
}
