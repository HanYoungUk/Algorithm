using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            // 세로로 읽는다

            Dictionary<int, string> dic = new Dictionary<int, string>();

            for (int i = 0; i < 5; i++) // 5개 줄까지 있다고 했으니까
            {
                string str = Console.ReadLine();

                for (int j = 0; j < str.Length; j++)
                {
                    if (dic.ContainsKey(j)) // 이미 키가 있으면 값에 이어붙이기
                    {
                        dic[j] += str[j];
                    }
                    else // 없으면 새로 추가
                    {
                        dic.Add(j, str[j].ToString());
                    }
                }
            }

            foreach (var value in dic.Values)
            {
                sb.Append(value);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
