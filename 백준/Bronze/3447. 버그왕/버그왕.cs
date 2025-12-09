using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
        string? line;

        while ((line = Console.ReadLine()) != null) // EOF까지 읽기
        {
            // BUG가 더 이상 없을 때까지 반복 제거
            while (line.Contains("BUG"))
            {
                line = line.Replace("BUG", "");
            }

            sb.AppendLine(line);
        }

        Console.Write(sb.ToString());
        }
    }
}
