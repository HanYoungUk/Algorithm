using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string result = ""; // 출력해줄 변수

            for(int i = 0; i < str.Length; i++) // str의 길이만큼 반복
            {
                 result += str[i]; // 글자를 더함

                 if(i == str.Length - 1 && result.Length < 10) // 마지막 인덱스인데 result가 10글자를 못채웠을 경우
                 {
                     Console.WriteLine(result);
                     break;
                 }     
                 if(result.Length == 10) // 10글자인 경우
                 {
                     Console.WriteLine(result);
                     result = ""; // 초기화
                 }
            }
        }
    }
}