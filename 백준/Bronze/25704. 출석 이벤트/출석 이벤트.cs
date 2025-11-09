using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = int.Parse(Console.ReadLine());

            int price = int.Parse(Console.ReadLine());

            List<double> list = new List<double>(); // 할인된 가격이 담길 곳

            if (point > 4) // 출석도장 5개
            {
                list.Add(price - 500);
            }

            if (point > 9) // 출석도장 10개
            {
                double discount = price * 0.1;
                list.Add(price - discount);
            }

            if (point > 14) // 출석도장 15개
            {
                list.Add(price - 2000);
            }

            if (point > 19)  // 출석도장 20개
            {
                double discount = price * 0.25;
                list.Add(price - discount);
            }

            if (list.Count < 1)
            {
                list.Add(price);
            }

            double minPrice = list.Min();

            if (minPrice < 0)
            {
                minPrice = 0;
            }

            Console.WriteLine(minPrice);
        }
    }
}
