using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'I' || str[i] == 'O' || str[i] == 'S' || str[i] == 'H' || str[i] == 'Z' || str[i] == 'X' || str[i] == 'N')
                {
                    count++;
                }
            }

            if(count == str.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
