using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "c=", "c-", "dz=", "d-","lj", "nj", "s=", "z=" };

            string str = Console.ReadLine();

            foreach (var i in list)
            {
                if (str.Contains(i))
                {
                    str = str.Replace(i,"*");
                }
            }

            int count = str.Length;


            Console.WriteLine(count);
        
        }
    }
}
