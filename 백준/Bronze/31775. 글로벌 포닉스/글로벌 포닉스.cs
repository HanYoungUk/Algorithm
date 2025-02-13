using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>() { 'l', 'k', 'p'};
            for (int i = 0; i < 3; i++)
            {
                var s = Console.ReadLine();

                if (s[0] == 'l' || s[0] == 'k' || s[0] == 'p')
                {
                    list.Remove(s[0]);
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("GLOBAL");
            }
            else
            {
                Console.WriteLine("PONIX");
            }
        }
    }
}
