using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            List<double> list = new List<double>(); // 값을 담을 배열선언

            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double C = double.Parse(input[2]);


            list.Add(A * B / C);

            list.Add(A / B * C);

            list.Sort();
            int result = (int)list[1];
            Console.WriteLine(result);
        }
    }
}
