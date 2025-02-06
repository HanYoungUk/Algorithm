using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.Replace("a", "4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("s","5");
            Console.WriteLine(str);
        }
    }
}
