using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        List<char> ch = new List<char>(); // 중복되지 않고 저장하기 위한 변수 설정

        for (int i = 0; i < s.Length; i++)
        {
            answer[i] = -1; // 처음 나온 문자이면 -1이므로

            if (ch.IndexOf(s[i]) != -1) // 중복된 문자면
            {
                int count = 1; // 몇 번째일지 파악하기 위한 변수
                for(int j = i - 1; j >= 0; j--)
                {
                    if (s[j] == s[i])
                    {
                        answer[i] = count; // 몇번째인지 저장
                        break;
                    }
                    count++;
                }
            }
            ch.Add(s[i]);
        }
        return answer;
    }
}