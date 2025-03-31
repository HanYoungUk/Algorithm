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

                if (str.Contains("18") && str.Contains("17") != true)
                {
                    sb.AppendLine(str);
                    sb.AppendLine("mack");
                    sb.AppendLine();
                }
                else if (str.Contains("17") && str.Contains("18") != true)
                {
                    sb.AppendLine(str);
                    sb.AppendLine("zack");
                    sb.AppendLine();
                }
                else if(str.Contains("17") && str.Contains("18"))
                {
                    sb.AppendLine(str);
                    sb.AppendLine("both");
                    sb.AppendLine();
                }
                else
                {
                    sb.AppendLine(str);
                    sb.AppendLine("none");
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb.ToString());   
        }
    }
}
