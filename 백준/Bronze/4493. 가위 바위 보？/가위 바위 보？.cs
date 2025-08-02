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

            // R, P, S는 순서대로 바위, 보, 가위

            for (int i = 0; i < count; i++) // 테스트 케이스
            {
                int count2 = int.Parse(Console.ReadLine()); // 가위바위보를 한 횟수

                int player1 = 0;
                int player2 = 0;

                for (int j = 0; j < count2; j++)
                {
                    string str = Console.ReadLine();

                    string[] arr = str.Split(" ");
                    string one = arr[0]; // 플레이어 원
                    string two = arr[1]; // 플레이어 투

                    if (one.Equals(two)) // 둘이 비김
                    {
                        continue;
                    }
                    else if (one.Equals("R") && two.Equals("S")) // 바위로 플레이어 원이 이겼을 경우
                    {
                        player1++;
                    }
                    else if (one.Equals("P") && two.Equals("R")) // 보로 플레이어 원이 이겼을 경우
                    {
                        player1++;
                    }
                    else if(one.Equals("S") && two.Equals("P")) // 가위로 플레이어 원이 이겼을 경우
                    {
                        player1++;
                    }
                    else
                    {
                        player2++;
                    }
                }
                if (player1 == player2)
                {
                    sb.AppendLine("TIE");
                }
                else if (player1 > player2)
                {
                    sb.AppendLine("Player 1");
                }
                else
                {
                    sb.AppendLine("Player 2");   
                }

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
