using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int num = 0;
            char ch = '@';
            bool firstCheck = false;
            while (true)
            {
                string str = Console.ReadLine();

                if (str.Equals("+"))
                {
                    ch = '+';
                }
                else if (str.Equals("-"))
                {
                    ch = '-';
                }
                else if (str.Equals("*"))
                {
                    ch = '*';
                }
                else if (str.Equals("/"))
                {
                    ch = '/';
                }
                else if (str.Equals("=")) // 마지막꺼 결과 대입
                {
                    break;
                }
                else // 숫자 일경우
                {
                    num = int.Parse(str);

                    if (firstCheck == false) 
                    {
                        firstCheck = true; 
                        result = num;  
                        continue;
                    }
                    if (ch == '+') { result += num; }
                    else if (ch == '-') { result -= num; }
                    else if (ch == '*') { result *= num; }
                    else if(ch == '/') { result /= num; }
                }
            }

            Console.WriteLine(result);
        }
    }
}
