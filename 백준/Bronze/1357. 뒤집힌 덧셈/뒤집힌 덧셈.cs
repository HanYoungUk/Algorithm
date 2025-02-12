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

            string a = string.Empty;
            string b = string.Empty;

            for (int i = arr[0].Length - 1; i >= 0; i--)
            {
                a += arr[0][i] - '0';
            }

            for (int i = arr[1].Length - 1; i >= 0; i--)
            {
                b += arr[1][i] - '0';
            }

            int A = int.Parse(a);
            int B = int.Parse(b);

            string sum = (A + B).ToString();
            string result = string.Empty;
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                result += sum[i];
            }
            int con = int.Parse(result);
            Console.WriteLine(con);
        }
    }
}
