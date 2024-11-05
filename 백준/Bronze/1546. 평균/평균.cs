using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());

            string str = Console.ReadLine();
            string[] arr = str.Split(" ");
            double sum = 0;

            List<int> list = new List<int>(); // 점수 담을거

            foreach(var i in arr)
            {
                list.Add(Int32.Parse(i));
            }
            list.Sort();

            double max = list[list.Count - 1]; // 최댓값

            for (int i = 0; i < arr.Length; i++)
            {
                sum += list[i] / max * 100;
            }

            double average = sum / count;

            Console.WriteLine(average);
        }
    }
}