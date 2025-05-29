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
                int count2 = int.Parse(Console.ReadLine());
                int max = 0;
                string maxname = "";
                for (int j = 0; j < count2; j++)
                {
                    string str = Console.ReadLine();
                    string[] arr = str.Split(" ");

                    int x = int.Parse(arr[0]);
                    string name = arr[1];
                    if (x > max)
                    {
                        maxname = name;
                        max = x;
                    }
                }
                sb.AppendLine(maxname);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
