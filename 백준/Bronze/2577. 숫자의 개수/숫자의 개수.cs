using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = Int32.Parse(Console.ReadLine()); // A를 입력받음
             int b = Int32.Parse(Console.ReadLine()); // B를 입력받음
             int c = Int32.Parse(Console.ReadLine()); // C를 입력받음

             long abc = a * b * c;
             string str = abc.ToString(); // string으로 변환

             Dictionary<int, int> dic = new Dictionary<int, int>(); // 결과를 담을 딕셔너리

             for(int i = 0; i <= 9; i++)
             {
                 int count = 0;
                 for(int j = 0; j < str.Length; j++)
                 {
                     if (str[j] - '0' == i)
                     {
                         count++;
                     }
                 }
                 dic.Add(i, count);
             }

             foreach(var i in dic.Values)
             {
                 Console.WriteLine(i);
             }
        }
    }
}