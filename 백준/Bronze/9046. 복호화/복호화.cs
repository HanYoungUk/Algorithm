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
                string str = Console.ReadLine();

                Dictionary<char, int> dic = new Dictionary<char, int>();

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == ' ') continue;

                    if (dic.ContainsKey(str[j]))
                        dic[str[j]]++;
                    else
                        dic.Add(str[j], 1); // 여기 수정
                }

                int dicMax = dic.Values.Max();

                string result = string.Empty;

                foreach (var x in dic)
                {
                    if (x.Value == dicMax)
                    {
                        result += x.Key; // 여기 수정
                    }
                }

                if (result.Length >= 2)
                    sb.AppendLine("?");
                else
                    sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
