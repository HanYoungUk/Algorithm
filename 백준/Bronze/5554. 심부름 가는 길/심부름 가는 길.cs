using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int second1 = int.Parse(Console.ReadLine());
            int second2 = int.Parse(Console.ReadLine());
            int second3 = int.Parse(Console.ReadLine());
            int second4 = int.Parse(Console.ReadLine());

            int sum = second1 + second2 + second3 + second4;

            int minute = sum / 60;
            int remain = sum % 60;

            Console.WriteLine(minute);
            Console.WriteLine(remain);
        }
    }
}
