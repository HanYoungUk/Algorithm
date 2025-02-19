using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                int count = int.Parse(Console.ReadLine());

                list.Add(count);
            }

            double average = list.Average();
            list.Sort();
            int middle = list[2];

            sb.AppendLine(average.ToString());
            sb.AppendLine(middle.ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
