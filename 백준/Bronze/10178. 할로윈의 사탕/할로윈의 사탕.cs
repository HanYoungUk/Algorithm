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

                int total = int.Parse(arr[0]);
                int human = int.Parse(arr[1]);

                int value = total / human;
                int value2 = total % human;

                sb.AppendLine($"You get {value} piece(s) and your dad gets {value2} piece(s).");

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
