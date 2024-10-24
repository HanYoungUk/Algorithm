using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] arr = Console.ReadLine().Split(" ");

             int total = int.Parse(arr[0]);
             int award = int.Parse(arr[1]);

             string[] arr2 = Console.ReadLine().Split(" "); // 각 사람들의 점수

             List<int> list = new List<int>(); // 정렬을 위한 List

             foreach(var i in arr2)
             {
                 list.Add(int.Parse(i));
             }

             list.Sort(); // 정렬
             list.Reverse(); // 내림차순 정렬

             Console.WriteLine(list[award - 1]);        
        }
    }
}