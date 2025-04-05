using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                dic.Add(i, 0);
            }
            int stop = 0;
            while (true)
            {
                stop++;
                if (stop == 51)
                {
                    break;
                }
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) continue;

                for (int j = 0; j < str.Length; j++)
                {
                    if (dic.ContainsKey(str[j])) 
                    {
                        dic[str[j]]++;
                    }
                }
            }

            int maxValue = dic.Values.Max();

            foreach (var i in dic)
            {
                if (i.Value == maxValue)
                {
                    sb.Append(i.Key);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
