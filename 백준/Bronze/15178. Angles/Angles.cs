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

                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);
                int c = int.Parse(arr[2]);

                int sum = a + b + c;

                if(sum == 180)
                {
                    sb.AppendLine($"{a} {b} {c} Seems OK");
                }
                else
                {
                    sb.AppendLine($"{a} {b} {c} Check");
                }
            }
            Console.WriteLine( sb.ToString() );
        }
    }
}
