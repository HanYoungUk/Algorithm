using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine()); // 횟수를 가져옴

             List<int> list = new List<int>(); // 숫자들을 입력받을 list 선언
             for(int i = 0; i < num; i++)
             {
                 int x = int.Parse(Console.ReadLine()); // 숫자를 입력 받음

                 if(x == 0)
                 {
                     if(list.Count > 0)
                     {
                         list.RemoveAt(list.Count - 1);
                     }
                 }
                 else
                 {
                     list.Add(x);
                 }
             }

             int sum = 0; // 합계 구하기용
             foreach (int x in list)
             {
                 sum += x;
             }
             Console.WriteLine(sum);    
        }
    }
}