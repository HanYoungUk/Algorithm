using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(); // 오름차순에 쓸 List
            for(int i = 0; i < N; i++)
            {
                int x = int.Parse(Console.ReadLine()); // 숫자를 입력받음

                list.Add(x);
            }
            list.Sort();

            StringBuilder sb = new StringBuilder();
            foreach (int x in list)
            {
                sb.AppendLine(x.ToString());
            }

            Console.WriteLine(sb.ToString());    
        }
    }
}