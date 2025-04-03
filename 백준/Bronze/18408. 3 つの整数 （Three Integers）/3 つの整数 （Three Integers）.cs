using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            var arr = str.Split(" ");

            int one = 0;
            int two = 0;

            foreach (var i in arr)
            {
                if (i.Equals("1"))
                {
                    one++;
                }
                else
                {
                    two++;
                }
            }

            if (one > two)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }
}
