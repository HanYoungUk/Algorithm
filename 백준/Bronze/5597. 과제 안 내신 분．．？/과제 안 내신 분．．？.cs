using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] arr = new int[31]; // 전체 인원 배열

            for(int i = 0; i < 28; i++)
            {
                int x = Int32.Parse(Console.ReadLine()); // 출석한 사람의 번호를 받음

                arr[x] = -1;
            }

            for(int i = 1; i <= 30; i++) // 1부터 30까지 확인
            {    
                if(arr[i] != -1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}