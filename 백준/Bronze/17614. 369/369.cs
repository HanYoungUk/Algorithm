using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            int result = 0;
            // 3 , 6, 9게임인데 각 자리수 확인하면 될듯
            for (int i = 1; i <= count; i++)
            {
                string ex = i.ToString();

                for (int j = ex.Length -1; j >= 0; j--)
                {
                    if (ex[j] == '3' | ex[j] == '6' || ex[j] == '9')
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
