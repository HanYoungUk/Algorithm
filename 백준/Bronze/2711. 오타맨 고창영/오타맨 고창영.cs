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
                StringBuilder sb2 = new StringBuilder();
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int location = int.Parse(arr[0]);
                string text = arr[1];

                for (int j = 0; j < text.Length; j++)
                {
                    if (j + 1 == location)
                    {
                        continue;
                    }
                    else
                    {
                        sb2.Append(text[j]);
                    }
                }
                string result = sb2.ToString();
                sb.AppendLine(result);
            }

            Console.WriteLine(sb.ToString()); 
        }
    }
}
