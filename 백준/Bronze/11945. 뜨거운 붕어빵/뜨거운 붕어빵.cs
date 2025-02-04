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
            int count = int.Parse(arr[0]);

            for (int i = 0; i < count; i++)
            {
                string ss = Console.ReadLine();

                string result = "";
                for (int j = ss.Length - 1; j >= 0; j--)
                {
                    result += ss[j];
                }
                sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
