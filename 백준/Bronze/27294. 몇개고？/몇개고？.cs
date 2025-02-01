using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int num = int.Parse(arr[0]);
            int num2 = int.Parse(arr[1]);


            if (num >= 12 && num <= 16) // 점심시간 
            {
                if(num2 == 0) // 술 없이 먹음
                {
                    Console.WriteLine(320);
                }
                else
                {
                    Console.WriteLine(280);
                }
            }
            else
            {
                Console.WriteLine(280);
            }
        }
    }
}
