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

            int monster = int.Parse(arr[0]);
            int human = int.Parse(arr[1]);
            double humanPercent = human / 100.0;

            double mBarrier = monster - (monster * humanPercent);

            if (mBarrier >= 100)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}
