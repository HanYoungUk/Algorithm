using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int sum = int.Parse(arr[0]) + int.Parse(arr[1]) + int.Parse(arr[2]);

            if (sum >= 100)
            {
                Console.WriteLine("OK");
                return;
            }
            else
            {
                List<int> list = new List<int> ();

                foreach (var i in arr)
                {
                    list.Add(int.Parse(i));
                }
                int min = list.Min();
                int result = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals($"{min}"))
                    {
                        result = i;
                        break;
                    }
                }

                if (result == 0)
                {
                    Console.WriteLine("Soongsil");
                }
                else if (result == 1)
                {
                    Console.WriteLine("Korea");
                }
                else
                {
                    Console.WriteLine("Hanyang");
                }
            }
        }
    }
}
