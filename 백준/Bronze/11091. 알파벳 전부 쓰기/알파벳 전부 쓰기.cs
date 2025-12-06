using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());



            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine().ToLower();

                Dictionary<char, int> dic = new Dictionary<char, int>();

                for (char x = 'a'; x <= 'z'; x++) // 알파벳을 담음
                {
                    dic.Add(x, 0);
                }

                foreach (var x in str)
                {
                    dic[x] = 1;
                }

                string s = "";

                foreach (var j in dic)
                {
                    if (j.Value == 0)
                    {
                        s += j.Key;
                    }
                }

                if (s.Length > 0) // missing
                {
                    sb.AppendLine($"missing {s}");
                }
                else
                {
                    sb.AppendLine($"pangram");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
