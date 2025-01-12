using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            long count = int.Parse(Console.ReadLine());
            int num = 0;
            string result = "";
            for(int i = 0; i < count; i++)
            {
                if(num == 0)
                {
                    result = "U";
                }
                else if(num == 1)
                {
                    result = "O";
                }
                else if (num == 2)
                {
                    result = "S";
                }
                num++;
                if(num == 3)
                {
                    num = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
}
