using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             Dictionary<char, int> dic = new Dictionary<char, int>();

             int length = int.Parse(Console.ReadLine()); // 로고의 길이
             string loggo = Console.ReadLine(); // 로고

             for(char i = 'a'; i <= 'z'; i++)
             {
                 int count = 0; // 몇개인지 세어줄 변수
                 for(int j = 0; j < loggo.Length; j++)
                 {
                     if (i == loggo[j]) // 같을 경우
                     {
                         count++; 
                     }
                 }
                 dic.Add(i, count);
             }

             int max = 0;

             foreach(var i in dic) // 최대값 확인
             {
                 if(max < i.Value)
                 {
                     max = i.Value;
                 }
             }
             Console.WriteLine(max);
        }
    }
}