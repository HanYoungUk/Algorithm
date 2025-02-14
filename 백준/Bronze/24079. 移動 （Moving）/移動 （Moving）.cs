using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            if (list[2] >= list[0] + list[1])
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
