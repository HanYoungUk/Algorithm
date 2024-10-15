using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0; // 최댓값.
            int row = 0; // 행
            int column = 0; // 열
            for(int i = 0; i < 9; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");

                for(int j = 0; j < arr.Length; j++) // arr의 길이만큼 반복
                {
                    int value = int.Parse(arr[j]);

                    if(value > max)
                    {
                        max = value;
                        row = i + 1;
                        column = j + 1;
                    }
                }
            }
            if(max == 0) // 최대값이 0 일경우
            {
                row = 1;
                column = 1;
            }
            Console.WriteLine(max);
            Console.WriteLine(row + " " + column);
        }
    }
}