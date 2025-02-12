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

            int a = list[0] + list[3];
            int b = list[1] + list[2];

            int result = Math.Abs(b - a);

            Console.WriteLine(result);
        }
    }
}
