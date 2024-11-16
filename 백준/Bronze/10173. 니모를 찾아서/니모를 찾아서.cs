using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              List<string> list = new List<string>(); // 결과를 담을 List

              while (true)
              {
                  string word = Console.ReadLine();

                  if (word.Equals("EOI"))
                  {
                      break;
                  }

                  word = word.ToLower(); // 다 소문자로 바꿈.

                  if (word.Contains("nemo"))
                  {
                      list.Add("Found");
                  }
                  else
                  {
                      list.Add("Missing");
                  }
              }
              foreach (string s in list)
              {
                  Console.WriteLine(s);
              }
        }
    }
}