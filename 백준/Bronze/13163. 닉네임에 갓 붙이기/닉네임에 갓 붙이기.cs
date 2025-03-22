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

              // 횟수 만큼 반복
              for(int i = 0; i < count; i++)
              {
                  // 입력 받음
                  string str = Console.ReadLine();
                  string[] arr = str.Split(" ");

                  string result = "god";

                  for(int j = 1; j < arr.Length; j++)
                  {
                      result += arr[j];
                  }
                  sb.AppendLine(result);
              }

              Console.WriteLine(sb.ToString());
        }
    }
}
