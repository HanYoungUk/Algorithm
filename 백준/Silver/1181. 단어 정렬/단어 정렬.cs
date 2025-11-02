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

            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                set.Add(Console.ReadLine());
            }

            for (int i = 1; i<= 50; i++)
            {
                foreach (var x in set)
                {
                    if (x.Length == i)
                    {

                        sb.AppendLine(x);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
