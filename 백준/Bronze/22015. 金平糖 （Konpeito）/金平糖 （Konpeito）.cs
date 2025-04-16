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

            List<int> list = new List<int>();

            foreach (var i in arr)
            {
                list.Add(int.Parse(i));
            }

            list.Sort();

            int result = (list[2] - list[0]) + (list[2] - list[1]);

            Console.WriteLine(result);
        }
    }
}
