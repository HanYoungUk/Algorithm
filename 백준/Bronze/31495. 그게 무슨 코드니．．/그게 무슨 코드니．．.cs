using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str[0] == '\"' && str[str.Length - 1] == '\"') 
            {
                string result = str.Replace("\"", "");

                if (result.Length == 0)
                {
                    Console.WriteLine("CE");
                    return;
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("CE");
            }
        }
    }
}
