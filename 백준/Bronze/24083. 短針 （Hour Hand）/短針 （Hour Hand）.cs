using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num + num2;

            if (sum > 12)
            {
                sum = sum % 12;
                if (sum == 0)
                {
                    sum = 12;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
