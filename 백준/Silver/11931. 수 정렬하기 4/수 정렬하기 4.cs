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

            List<int> list = new List<int>();

            for(int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
            }

            list.Sort();
            list.Reverse();

            foreach(var i in list)
            {
                sb.AppendLine(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
