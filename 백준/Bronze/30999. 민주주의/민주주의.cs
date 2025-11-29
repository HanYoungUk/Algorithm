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

            int count = int.Parse(arr[0]);

            int opinion = int.Parse(arr[1]);
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                string st = Console.ReadLine();

                int agree = 0;

                for (int j = 0; j < st.Length; j++)
                {
                    if (st[j] == 'O') // 찬성일경우
                    {
                        agree++;
                    }
                }

                if (agree > opinion / 2)
                {
                    result++;
                }

            }
            Console.WriteLine(result);
        }
    }
}
