using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for(int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                if (name.Contains("S"))
                {
                    result = name;
                }
            }
            Console.WriteLine(result);
        }
    }
}