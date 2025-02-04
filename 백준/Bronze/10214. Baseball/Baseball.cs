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
            
            for (int i = 0; i < count; i++)
            {
                int yonsei = 0;
                int korea = 0;

                for (int j = 0; j < 9; j++)
                {
                    string str = Console.ReadLine();
                    string[] arr = str.Split(" ");

                    int yon = int.Parse(arr[0]);
                    int kor = int.Parse(arr[1]);

                    yonsei += yon;
                    korea += kor;
                }

                if (yonsei > korea)
                {
                    sb.AppendLine("Yonsei");
                }
                else if (korea > yonsei)
                {
                    sb.AppendLine("Korea");
                }
                else
                {
                    sb.AppendLine("Draw");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
