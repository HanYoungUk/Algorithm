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

                string ss = "";
                string up = arr[0];

                for(int j = 0; j < up.Length; j++)
                {
                    if(j == 0 && up[j] >= 97)
                    {
                        ss += (char)(up[j] - 32);
                    }
                    else
                    {
                        ss += (char)(up[j]);
                    }
                }
                sb.Append(ss);
                for(int j = 1; j < arr.Length; j++)
                {
                    sb.Append(" " + arr[j]);
                }
                    sb.AppendLine();
                }
                Console.WriteLine(sb.ToString());
        }
    }
}
