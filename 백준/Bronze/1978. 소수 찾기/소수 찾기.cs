using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int count = 0;
            string[] arr = str.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                var number = int.Parse(arr[i]);

                for (int j = 2; j <= number; j++)
                {
                    if (number % j != 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (number == j)
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
