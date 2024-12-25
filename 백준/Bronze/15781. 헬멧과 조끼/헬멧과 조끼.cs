using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string str = Console.ReadLine();
             string[] arr = str.Split(" ");

             int H = int.Parse(arr[0]);
             int J = int.Parse(arr[1]);

             string helmet = Console.ReadLine();
             string[] helmetList = helmet.Split(" ");

             int sum = 0; // 결과 구하기 위해 필요한 값
             int max = int.Parse(helmetList[0]); // 헬멧 최고 방어력 구하기

             // 헬멧 최고 크기 구하기
             for (int i = 1; i < H; i++)
             {  
                 if(max < int.Parse(helmetList[i]))
                 {
                     max = int.Parse(helmetList[i]);
                 }
                 else
                 {
                     continue;
                 }
             }
             sum += max;

             string vest = Console.ReadLine();
             string[] vestList = vest.Split(" ");

             max = int.Parse(vestList[0]);
             // 조끼 최고 크기 구하기
             for (int i = 1; i < J; i++)
             {
                 if (max < int.Parse(vestList[i]))
                 {
                     max = int.Parse(vestList[i]);
                 }
                 else
                 {
                     continue;
                 }
             }

             sum += max;
             Console.WriteLine(sum);
        }
    }
}