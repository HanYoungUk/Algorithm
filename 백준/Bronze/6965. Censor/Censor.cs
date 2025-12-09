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

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                List<string> list = new List<string>();

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length == 4)
                    {
                        list.Add("****");
                    }
                    else
                    {
                        list.Add(arr[j]);
                    }
                }

                foreach (var x in list)
                {
                    sb.Append($"{x} ");
                }
                sb.AppendLine();
                sb.AppendLine();
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
