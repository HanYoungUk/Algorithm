using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            SortedDictionary<int, string> dic = new SortedDictionary<int, string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                short s = short.Parse(arr[1]);

                dic.Add(s, arr[0]);
            }

            foreach (var i in dic)
            {
                Console.WriteLine(i.Value);
                break;
            }
        }
    }
}
