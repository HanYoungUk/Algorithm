using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            int M = int.Parse(Console.ReadLine());

            string[] arr = Console.ReadLine().Split(" ");

            List<int> list = new List<int>();



            foreach (var i in arr)
            {
                list.Add(int.Parse(i));
            }

            list.Sort();
            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = list.Count - 1; j >= 0; j--)
                {
                    if (list[i] + list[j] > M) // 구해야 하는 값보다 클경우
                    {
                        continue;
                    }
                    else if (list[i] + list[j] < M)
                    {
                        break;
                    }
                    else // 같을 경우
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count / 2);
        }
    }
}
