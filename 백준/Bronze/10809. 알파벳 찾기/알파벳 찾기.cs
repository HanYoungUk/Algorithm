using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string str = Console.ReadLine();

            for(char i = 'a'; i <= 'z'; i++)
            {
                dic.Add(i, -1);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (dic.ContainsKey(str[i]))
                {
                    if (dic[str[i]] == -1)
                    {
                        dic[str[i]] = i;
                    }
       
                }
            }

            foreach (var i in dic.Values)
            {
                Console.Write(i + " ");
            }
        }
    }
}