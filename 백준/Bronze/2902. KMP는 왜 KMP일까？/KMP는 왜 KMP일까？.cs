using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string name = Console.ReadLine();
            string[] arr = name.Split("-");

            for (int i = 0; i < arr.Length; i++)
            {
                string part = arr[i];

                sb.Append(part[0]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
