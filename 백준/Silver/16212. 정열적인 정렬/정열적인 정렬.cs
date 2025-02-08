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
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                list.Add(int.Parse(arr[i]));
            }

            list.Sort();
            foreach (var i in list)
            {
                sb.Append(i + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
