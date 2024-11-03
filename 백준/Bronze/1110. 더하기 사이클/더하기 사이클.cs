using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine()); // 사용자로부터 정수를 입력받음
            int first = x; // 돌아와야할 수
            int count = 0; // 반복횟수
            while (true)
            {
                if(count > 0 && first == x)
                {
                    Console.WriteLine(count);
                    break;
                }
                string y = x.ToString(); // string으로 바꿔줌
                if(y.Length == 1)
                {
                    y = $"{0}" + y;
                }
                string a = $"{y[1]}";
                int sum = 0;
                for(int i = 0; i < y.Length; i++)
                {
                    sum += y[i] - '0';
                }
                if(sum >= 10)
                {
                    string str = sum.ToString();
                    y = a + $"{str[1]}";
                }
                else
                {
                    y = a + $"{sum}";
                }
                x = Int32.Parse(y);
                count++;
            }
        }
    }
}