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
            int num3 = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(num);
            list.Add(num2);
            list.Add(num3);

            list.Sort();

            Console.WriteLine(list[1]);
        }
    }
}
