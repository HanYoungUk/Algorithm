using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int apple3 = int.Parse(Console.ReadLine());
            int apple2 = int.Parse(Console.ReadLine());
            int apple1 = int.Parse(Console.ReadLine());

            int banana3 = int.Parse(Console.ReadLine());
            int banana2 = int.Parse(Console.ReadLine());
            int banana1 = int.Parse(Console.ReadLine());

            int appletotal = apple3 * 3 + apple2 * 2 + apple1;
            int bananatotal = banana3 * 3 + banana2 * 2 + banana1;

            if(appletotal > bananatotal)
            {
                Console.WriteLine("A");
            }
            else if (appletotal < bananatotal)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("T");
            }
        }
    }
}
