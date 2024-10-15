using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string socks = Console.ReadLine();

             int Bcount = 0; // 블랙 양말
             int Ccount = 0; // 흰색 양말

             int answer = 0; // 결과를 담는 용도
             for(int i = 0; i < socks.Length; i++)
             {
                 if (socks[i] == 'B')
                 {
                     Bcount++;
                     if (Bcount == 2)
                     {
                         answer++;
                         Bcount = 0;
                     }
                 }
                 else if (socks[i] == 'C')
                 {
                     Ccount++;
                     if (Ccount == 2)
                     {
                         answer++;
                         Ccount = 0;
                     }
                 }
             }

             Console.WriteLine(answer);
        }
    }
}