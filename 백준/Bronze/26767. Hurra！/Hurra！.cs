using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            
            for(int i = 1; i <= num; i++)
            {
                if(i % 7 == 0 && i % 11 == 0) // 7과 11로 나눠질 경우
                {
                    output.AppendLine("Wiwat!");
                }
                else if(i % 7 == 0) // 7로 나눠질 경우
                {
                     output.AppendLine("Hurra!");
                }
                else if(i % 11 == 0) // 11로 나눠질 경우
                {
                    output.AppendLine("Super!");
                }
                else // 아닐 경우
                {
                    output.AppendLine(i.ToString());
                }
            }
            Console.Write(output.ToString());  // 출력
        }
    }
}