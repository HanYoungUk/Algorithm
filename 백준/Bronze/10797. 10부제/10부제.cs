using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(date))
                {
                    string ss = arr[i];
                    if ($"{ss[ss.Length - 1]}".Equals(date))
                    {
                        count++;
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(count);
        }
    }
}
