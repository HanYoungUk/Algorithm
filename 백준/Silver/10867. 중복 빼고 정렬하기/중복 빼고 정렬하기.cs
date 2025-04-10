using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");
            SortedSet<int> set = new SortedSet<int>();

            for (int i = 0; i < count; i++)
            {
                set.Add(int.Parse(arr[i]));
            }

            foreach (var i in set)
            {
                sb.Append(i + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
