using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] minkook = str.Split(" ");

            str = Console.ReadLine();

            string[] manse = str.Split(" ");

            int sum1 = 0;
            int sum2 = 0;

            foreach (var i in minkook)
            {
                sum1 += int.Parse(i);
            }

            foreach(var i in manse)
            {
                sum2 += int.Parse(i);
            }

            if(sum1 >= sum2)
            {
                Console.WriteLine(sum1);
            }
            else
            {
                Console.WriteLine(sum2);
            }
        }
    }
}
