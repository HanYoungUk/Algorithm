using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                int legs = int.Parse(arr[0]); // 다리 수
                int chicken = int.Parse(arr[1]); // 닭의 수

                int slice = (chicken * 2) - legs; // 잘린 다리

                sb.AppendLine($"{slice} {chicken - slice}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
