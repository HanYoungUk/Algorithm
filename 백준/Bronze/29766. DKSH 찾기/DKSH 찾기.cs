using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.Replace("DKSH", ",");

            if (str.Contains(","))
            {
                int commaCount = str.Count(c => c == ',');
                Console.WriteLine(commaCount);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}