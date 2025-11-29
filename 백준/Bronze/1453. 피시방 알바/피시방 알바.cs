using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            List<int> list = new List<int>();

            foreach (var i in arr)
            {
                list.Add(int.Parse(i));
            }

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < list.Count; i++) // 순차적으로 돌면서 비교할려고
            {
                if (dic.ContainsKey(list[i])) // 포함되어 있으면 이미 자리에 착석한거므로
                {
                    result++;
                }
                else // 자리가 있다
                {
                    dic.Add(list[i], 0);
                }
            }
            Console.WriteLine(result);
        }
    }
}
