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

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                List<int> list = new List<int>();
                for(int j = 0; j < arr.Length; j++)
                {
                    list.Add(int.Parse(arr[j]));
                }
                list.Sort();

                sb.AppendLine(list[list.Count - 3].ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
