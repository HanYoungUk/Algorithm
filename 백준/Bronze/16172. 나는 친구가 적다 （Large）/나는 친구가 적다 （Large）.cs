using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string text = Console.ReadLine();

            string check = Console.ReadLine();


            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6'
                    || text[i] == '7' || text[i] == '8' || text[i] == '9')
                {
                    continue;
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            string str = sb.ToString();
            if (str.Contains(check)) // 포함되어 있으면 1
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
