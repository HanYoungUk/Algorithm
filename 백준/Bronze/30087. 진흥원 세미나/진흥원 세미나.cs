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

                if (str.Equals("Algorithm"))
                {
                    sb.AppendLine("204");
                }
                else if (str.Equals("DataAnalysis"))
                {
                    sb.AppendLine("207");
                }
                else if (str.Equals("ArtificialIntelligence"))
                {
                    sb.AppendLine("302");
                }
                else if (str.Equals("CyberSecurity"))
                {
                    sb.AppendLine("B101");
                }
                else if (str.Equals("Network"))
                {
                    sb.AppendLine("303");
                }
                else if (str.Equals("Startup"))
                {
                    sb.AppendLine("501");
                }
                else if (str.Equals("TestStrategy"))
                {
                    sb.AppendLine("105");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
