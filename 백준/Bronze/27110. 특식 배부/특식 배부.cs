using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int human = int.Parse(Console.ReadLine());
            int sum = 0;
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int A = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);
            int C = int.Parse(arr[2]);

            sum += human >= A ? A : human;
            sum += human >= B ? B : human;
            sum += human >= C ? C : human;

            Console.WriteLine(sum);
        }
    }
}
