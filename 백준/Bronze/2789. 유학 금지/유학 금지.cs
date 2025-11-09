using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = "CAMBRIDGE";

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < str.Length; i++)
            {
                dic.Add(str[i], 0);
            }

            str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    continue;
                }
                else
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
