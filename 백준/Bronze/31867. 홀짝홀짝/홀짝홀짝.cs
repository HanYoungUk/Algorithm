using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            int odd = 0;
            int even = 0;

            for(int i = 0; i < count; i++)
            {
                if (str[i] % 2 == 0) // 짝수
                {
                    even++;
                }
                else // 홀수
                {
                    odd++;
                }
            }


            if(odd == even)
            {
                Console.WriteLine(-1);
            }
            else if (odd > even)
            {
                Console.WriteLine(1);
            }
            else if(odd < even)
            {
                Console.WriteLine(0);
            }
        }
    }
}
