using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] arr = Console.ReadLine().Split(" "); // N과 K를 받음

             int N = int.Parse(arr[0]); // 동전의 개수
             int K = int.Parse(arr[1]); // 필요한 값
             List<int> list = new List<int>(); // 돈들을 담을 list
             int count = 0; // 최소값

             for(int i = 0; i < N; i++)
             {
                 int coin = int.Parse(Console.ReadLine()); // 돈의 값어치를 입력 받음
     
                 list.Add(coin);
             }

             list.Sort();
             list.Reverse(); // 내림차순으로 정렬

             foreach(var i in list)
             {
                 if(K / i >= 1) // 몫이 존재할 경우
                 {
                     count += K / i;
                     K = K - ((K / i) * i);
                     if(K == 0)
                     {
                         break;
                     }
                 }
             }
             Console.WriteLine(count);      
        }
    }
}