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

            List<int> list = new List<int>();

            for(int i = 0; i < str.Length; i++)
            {
                list.Add(str[i] - '0');
            }

            list.Sort();
            list.Reverse();
            foreach (var i in list)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
