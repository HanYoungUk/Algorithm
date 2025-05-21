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
                int num = int.Parse(Console.ReadLine());

                sb.AppendLine($"{num} {num}");

            }

            Console.WriteLine( sb.ToString() );
        }
    }
}
