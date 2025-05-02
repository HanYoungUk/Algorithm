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

            string problem = Console.ReadLine();

            int[] numarr = new int[arr.Length];

            for (int i = 0; i < numarr.Length; i++)
            {
                numarr[i] = int.Parse(arr[i]);
            }

            Array.Sort(numarr);
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char ch = 'A';
            for(int i = 0; i < problem.Length; i++)
            {
                dic.Add(ch, numarr[i]);
                ch++;
            }

            for(int i = 0; i < problem.Length; i++)
            {
                int x = dic[problem[i]];

                sb.Append(x + " ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
