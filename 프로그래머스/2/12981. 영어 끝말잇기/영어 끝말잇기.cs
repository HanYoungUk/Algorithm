using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        int[] answer = new int[2];
        int count = 1; // 몇번인지 세줄 변수(미세하게)
        int human = 1; // 몇번째 사람인지
        int order = 1; // 차례 변수
        char last = words[0][words[0].Length - 1]; // 마지막 단어
        List<string> list = new List<string>(); // 이미 썼는지 확인할 리스트
        list.Add(words[0]);

        for (int i = 1; i < words.Length; i++)
        {
            human++; // 지금 사람
            count++;

            if (list.IndexOf(words[i]) != -1) // 이미 썼던 단어
            {
                answer[0] = human;
                answer[1] = order;
                break;
            }
            if(last != words[i][0]) // 첫글자가 안맞을 경우
            {
                answer[0] = human;
                answer[1] = order;
                break;
            }
            if (words[i].Length == 1) // 한글자인 경우
            {
                answer[0] = human;
                answer[1] = order;
                break;
            }

            list.Add(words[i]); // 쓴 단어 추가

            if(count == n) // 다 돌았을 경우
            {
                order++;
                count = 0;

            }
            if(human == n)
            {
                human = 0;
            }
            last = words[i][words[i].Length - 1]; // 마지막 단어
        }
       
        return answer;
    }
}