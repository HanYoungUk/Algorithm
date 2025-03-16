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

                if(str.Length > 5 && str.Length < 10)
                {
                    sb.AppendLine("yes");
                }
                else
                {
                    sb.AppendLine("no");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
