using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        { 
            string str = Console.ReadLine();

            if (str.Equals("SONGDO"))
            {
                Console.WriteLine("HIGHSCHOOL");
            }
            else if (str.Equals("CODE"))
            {
                Console.WriteLine("MASTER");
            }
            else if (str.Equals("2023"))
            {
                Console.WriteLine("0611");
            }
            else if (str.Equals("ALGORITHM"))
            {
                Console.WriteLine("CONTEST");
            }
        }
    }
}
