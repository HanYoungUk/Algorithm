using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string str = Console.ReadLine();

                if (str.Equals("0 0 0"))
                {
                    break;
                }

                string[] arr = str.Split(" ");

                List<int> list = new List<int>();

                foreach (var i in arr)
                {
                    list.Add(int.Parse(i));
                }

                list.Sort();

                if (list[0] + list[1] <= list[2])
                {
                    sb.AppendLine("Invalid");
                    continue;
                }


                if (list[0] == list[1] && list[1] == list[2])
                {
                    sb.AppendLine("Equilateral");
                }
                else if (list[0] != list[1] && list[1] != list[2])
                {
                    sb.AppendLine("Scalene");
                }
                else
                {
                    sb.AppendLine("Isosceles");
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
