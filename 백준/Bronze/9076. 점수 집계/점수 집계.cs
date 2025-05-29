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

            int i = 0;
            while (i++ < count)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                List<int> list = new List<int>();

                foreach(var a in arr)
                {
                    list.Add(int.Parse(a));
                }

                list.Sort();

                int max = list[3];
                int min = list[1];
                int middle = list[2];

                if (max - min >= 4) // 점수차가 4점 이상일 경우
                {
                    sb.AppendLine("KIN");
                }
                else
                {
                    sb.AppendLine((max + min + middle).ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
