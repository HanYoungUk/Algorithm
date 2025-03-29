using System;
using System.Text;
using System.Numerics;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());
             StringBuilder sb = new StringBuilder();
             for(int i = 0; i < count; i++)
             {
                 string[] arr = Console.ReadLine().Split(" ");
                 int co = int.Parse(arr[0]);
                 double sum = 0;
                 for(int j = 1; j < arr.Length; j++) // 평균 구하기용
                 {
                     double num = double.Parse(arr[j]);
                     sum += num;
                 }

                 double average = Math.Round((sum / co), 4); // 평균
                 double co2 = 0; // 높은 사람 구하기용 변수
                 for (int j = 1; j < arr.Length; j++) // 평균 보다 높은 사람 구하기용
                 {
                     if(average < double.Parse(arr[j]))
                     {
                         co2++;
                     }
                 }

                 double highaverage = Math.Round((co2 / co), 4);
                 string percentage = highaverage.ToString("P3"); // %로 바꿔주고 소수점 자리를 정해줌
                 sb.AppendLine(percentage);
             }
             Console.WriteLine(sb.ToString());
        }
    }
}