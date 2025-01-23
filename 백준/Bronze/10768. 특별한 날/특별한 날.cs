using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            string str = month.ToString() + day;

            if (month == 2 && day == 18)
            {
                Console.WriteLine("Special");
            }
            else if (int.Parse(str) > 218 || month > 2)
            {
                Console.WriteLine("After");
            }
            else if (int.Parse(str) < 218)
            {
                Console.WriteLine("Before");
            }
        }
    }
}
