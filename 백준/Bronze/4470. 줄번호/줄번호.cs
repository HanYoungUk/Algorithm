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

                sb.AppendLine($"{i + 1}. {str}");
            }

            Console.WriteLine( sb.ToString() );
        }
    }
}
