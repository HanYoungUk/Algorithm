using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            var dic = new SortedDictionary<int, List<string>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");

                int age = int.Parse(arr[0]);
                string name = arr[1];

                if (!dic.ContainsKey(age))
                {
                    dic[age] = new List<string>();
                }

                dic[age].Add(name);

            }

            foreach (var i in dic)
            {
                foreach (var j in i.Value)
                {
                    sb.AppendLine($"{i.Key} {j}");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}