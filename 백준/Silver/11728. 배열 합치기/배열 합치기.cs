using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            List<int> list = new List<int>();

            str = Console.ReadLine();

            string[] arr2 = str.Split(" ");

            for(int i = 0; i < arr2.Length; i++)
            {
                list.Add(int.Parse(arr2[i]));
            }

            str = Console.ReadLine();

            string[] arr3 = str.Split(" ");

            for (int i = 0; i < arr3.Length; i++)
            {
                list.Add(int.Parse(arr3[i]));
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
