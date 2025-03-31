using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string ss = Console.ReadLine();

            str = str.Replace(ss, ",");

            int count = 0;
            foreach(var i in str)
            {
                if(i == ',')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
