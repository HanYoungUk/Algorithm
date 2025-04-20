using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string sum = "";
            string str;
            while ((str = Console.ReadLine()) != null)
            {
                sum += str;
                str = null;
            }

            string[] arr = sum.Split(',');
            long total = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                total += int.Parse(arr[i]);
            }

            Console.WriteLine(total);
        }
    }
}
