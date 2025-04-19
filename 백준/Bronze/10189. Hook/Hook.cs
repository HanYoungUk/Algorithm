using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("#  # #### #### #  #");
            sb.AppendLine("#### #  # #  # # #");
            sb.AppendLine("#### #  # #  # # #");
            sb.AppendLine("#  # #### #### #  #");

            Console.WriteLine(sb.ToString());
        }
    }
}
