using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            DateTime now = DateTime.Now;

            string year = now.ToString("yyyy");
            string day = now.ToString("dd");
            string month = now.ToString("MM");

            sb.AppendLine(year);
            sb.AppendLine(month);
            sb.AppendLine(day);

            Console.WriteLine(sb.ToString());
        }
    }
}
