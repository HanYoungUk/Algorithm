using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");

            int N = int.Parse(arr[0]);
            int K = int.Parse(arr[1]);


            List<int> list = new List<int>();

            str = Console.ReadLine();
            string[] arr2 = str.Split(" ");

            foreach (var i in arr2)
            {
                list.Add(int.Parse(i));
            }
            list.Sort();

            Console.WriteLine(list[K - 1]);
        }
    }
}