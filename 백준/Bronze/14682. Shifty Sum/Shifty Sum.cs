using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int sum = N;
            string str = N.ToString();

            for (int i = 0; i < k; i++)
            {
                str += "0";

                int x = int.Parse(str);

                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
