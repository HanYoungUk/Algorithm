using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<char> list = new List<char>() { 'M', 'O', 'B', 'I', 'S'};

            for(int i = 0; i < str.Length; i++)
            {
                for(int j = 0; j < list.Count; j++)
                {
                    if (list[j] == str[i])
                    {
                        list.Remove(str[i]);
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
