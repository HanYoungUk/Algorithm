using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string human = "";
            int result = 1;
            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals(human))
                {
                    continue;
                }
                else
                {
                    result++;
                    human = str;
                }
            }
            Console.WriteLine(result);
        }
    }
}
