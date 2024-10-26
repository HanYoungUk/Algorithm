using System;
using System.Collections.Generic;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = Int32.Parse(Console.ReadLine()); // 몇번 실행할 것인지 숫자를 입력 받음
             List<string> list = new List<string>(); // 결과를 담을 리스트
            
             for(int i = 0; i < count; i++) // 사용자에게서 명령받은 숫자만큼 반복
             {
                 string str = Console.ReadLine(); // 괄호를 입력받음
                 int num = 0; // 괄호를 세줄 변수
                 bool check = false;
                 
                 if (str[0] == ')') // 처음에 이거 일경우
                 {    
                      list.Add("NO");
                     continue;
                 }
                 if (str[str.Length - 1] == '(') // 마지막이 이거일 경우
                 {
                     list.Add("NO");
                     continue;
                 }
                 for (int j = 0; j < str.Length; j++) // 괄호를 세어줄 반복
                 {
                     if(num == 0 && str[j] == ')')
                     {
                         list.Add("NO");
                         check = true;
                         break;
                     }
                     if (str[j] == '(')
                     {
                         num++;
                     }
                     else if(str[j] == ')')
                     {
                         num--;
                     }
                 }
                 if(check == true)
                 {
                    continue;
                 }
                 if(num == 0)
                 {
                    list.Add("YES");
                 }
                 else 
                 {
                    list.Add("NO");
                    num = 0;
                  }
             }
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}