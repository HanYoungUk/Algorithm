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

                int num = int.Parse(arr[0]);
                string ss = arr[1];

                for(int j = 0; j < num; j++)
                {
                    sb.Append(ss);
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString()); 
        }
    }
}
