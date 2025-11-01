using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str.Equals("A+"))
            {
                Console.WriteLine("4.3");
            }
            else if (str.Equals("A0"))
            {
                Console.WriteLine("4.0");
            }
            else if (str.Equals("A-"))
            {
                Console.WriteLine("3.7");
            }
            else if (str.Equals("B+"))
            {
                Console.WriteLine("3.3");
            }
            else if (str.Equals("B0"))
            {
                Console.WriteLine("3.0");
            }
            else if (str.Equals("B-"))
            {
                Console.WriteLine("2.7");
            }
            else if (str.Equals("C+"))
            {
                Console.WriteLine("2.3");
            }
            else if (str.Equals("C0"))
            {
                Console.WriteLine("2.0");
            }
            else if (str.Equals("C-"))
            {
                Console.WriteLine("1.7");
            }
            else if (str.Equals("D+"))
            {
                Console.WriteLine("1.3");
            }
            else if (str.Equals("D0"))
            {
                Console.WriteLine("1.0");
            }
            else if (str.Equals("D-"))
            {
                Console.WriteLine("0.7");
            }
            else
            {
                Console.WriteLine("0.0");
            }
        }
    }
}
