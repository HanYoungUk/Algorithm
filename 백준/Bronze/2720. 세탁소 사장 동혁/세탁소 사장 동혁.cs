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

            for(int i = 0; i < count; i++)
            {
                int remain = int.Parse(Console.ReadLine());

                int Q = remain / 25; // 쿼터에 들어가는 내용
                sb.Append($"{Q} ");
                remain = remain % 25; // 나머지

                int D = remain / 10; // 다임에 들어가는 내용
                sb.Append($"{D} ");
                remain = remain % 10;

                int N = remain / 5; // 니켈에 들어가는 내용
                sb.Append($"{N} ");
                remain = remain % 5;

                //Console.WriteLine(remain);
                int P = remain / 1; // 페니에 들어가는 내용
                sb.Append($"{P}");

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
