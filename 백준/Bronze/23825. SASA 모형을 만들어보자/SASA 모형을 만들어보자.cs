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
            List<int> list = new List<int>();
            foreach (var i in arr)
            {
                list.Add(int.Parse(i));
            }

            list.Sort();

            int result = list[0] / 2;

            Console.WriteLine(result);
        }
    }
}
