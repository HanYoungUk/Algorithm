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

            int x = int.Parse(arr[0]);
            int y = int.Parse(arr[1]);

            str = Console.ReadLine();
            var arr1 = str.Split(" ");

            int expense1 = int.Parse(arr1[0]);
            int expense2 = int.Parse(arr1[1]);

            int result = 0;
            if (x >= y)
            {
                result = expense1 * y;
            }
            else if (y > x)
            {
                result = (x * expense1) + (y - x) * expense2;  
            }

            Console.WriteLine(result);
        }
    }
}
