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

            int N = int.Parse(arr[0]);
            int K = int.Parse(arr[1]);

            int result = 0;

            SortedSet<int> list = new SortedSet<int>();

            for (int i = 1; i <= K; i++)
            {
                string x = (N * i).ToString(); // 뒤집기를 할려고하는 것

                string value = new string(x.Reverse().ToArray());

                list.Add(int.Parse(value));
            }

            Console.WriteLine(list.Max);
        }
    }
}
