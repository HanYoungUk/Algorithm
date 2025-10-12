using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int D = 0;
            int P = 0;

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                if (D + 1 < P)
                {
                    continue;
                }
                else if (P + 1 < D)
                {
                    continue;
                }

                if (str.Equals("D"))
                {
                    D++;
                }
                else
                {
                    P++;
                }
            }

            Console.WriteLine($"{D}:{P}");
        }
    }
}
