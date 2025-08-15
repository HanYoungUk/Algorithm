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

            int N = int.Parse(arr[0]);
            int L = int.Parse(arr[1]);

            string str2 = Console.ReadLine();

            string[] arr2 = str2.Split(" ");

            List<int> list = new List<int>();

            foreach (var i in arr2)
            {
                list.Add(int.Parse(i));
            }
            list.Sort();

            foreach (var i in list)
            {
                if (L >= i)
                {
                    L++;
                }
            }
            Console.WriteLine(L);
        }
    }
}
