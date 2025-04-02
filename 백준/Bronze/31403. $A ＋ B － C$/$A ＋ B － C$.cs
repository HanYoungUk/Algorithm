using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());    
            int C = int.Parse(Console.ReadLine());

            string sum = $"{A}{B}";
            int sum2 = int.Parse(sum);

            int value = A + B - C;
            int value2 = sum2 - C;

            Console.WriteLine(value);
            Console.WriteLine(value2);        
        }
    }
}