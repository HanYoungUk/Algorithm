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
                Dictionary<char, int> dic = new Dictionary<char, int>();

                for (char a = 'A'; a <= 'Z'; a++)
                {
                    dic.Add(a, 0);
                }

                long sum = 0;
                string str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    if (dic.ContainsKey(str[j]))
                    {
                        dic[str[j]]++;
                    }
                }
                foreach (var x in dic)
                {
                    if (x.Value == 0)
                    {
                        sum += (int)x.Key;
                    }
                }


                sb.AppendLine(sum.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
