using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int minus = 0;

            foreach (var i in arr)
            {
                if (i.Equals("1"))
                {
                    minus += 500;
                }
                else if (i.Equals("2"))
                {
                    minus += 800;
                }
                else if (i.Equals("3"))
                {
                    minus += 1000;
                }
            }

            int result = 5000 - minus;

            Console.WriteLine(result);
        }
    }
}
