using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int subject = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = subject; i >= 0; i--)
            {
                string num = i.ToString();

                num = num.Replace("4", "").Replace("7", "");

                if (num.Length == 0)
                {
                    result = i.ToString();
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
