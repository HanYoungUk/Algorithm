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
                int price = int.Parse(Console.ReadLine());

                int option = int.Parse(Console.ReadLine());

                if (option > 0) // 옵션이 0보다 많을 경우
                {
                    for (int j = 0; j < option; j++)
                    {
                        string str = Console.ReadLine();

                        string[] arr = str.Split(" ");

                        int num = int.Parse(arr[0]);
                        int price2 = int.Parse(arr[1]);

                        int calculate = num * price2;
                        price += calculate;
                    }
                }
                sb.AppendLine(price.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
