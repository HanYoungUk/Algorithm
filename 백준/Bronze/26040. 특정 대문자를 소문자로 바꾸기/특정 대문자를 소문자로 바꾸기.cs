using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string ch = Console.ReadLine();
            string[] arr = ch.Split(" ");


            for(int i = 0; i < arr.Length; i++)
            {
                str = str.Replace(arr[i], $"{(char)(arr[i][0] + 32)}");
            }


            Console.WriteLine(str);
        }
    }
}
