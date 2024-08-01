using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        List<string> list = new List<string>();
        string answer = "";
        bool check = true;

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += s[i];
                check = true;
            }
            else
            {
                if(check && s[i] >= 97 && s[i] <= 122) // 첫글자이면서 소문자일 경우
                {
                    answer += (char)(s[i] - 32);
                    check = false;
                }
                else if(check && s[i] >= 65 && s[i] <= 90) // 첫글자이면서 대문자일 경우
                {
                    answer += s[i];
                    check = false;
                }
                else if(check == false && s[i] >= 65 && s[i] <= 90) // 그 후 대문자일 경우
                {
                    answer += (char)(s[i] + 32);
                }
                else if(check == false && s[i] >= 97 && s[i] <= 122) // 그 후 소문자일 경우
                {
                    answer += s[i];
                }
                else // 숫자일 경우
                {
                    answer += s[i];
                    check = false;
                }
            }
        }
        return answer;
    }
}