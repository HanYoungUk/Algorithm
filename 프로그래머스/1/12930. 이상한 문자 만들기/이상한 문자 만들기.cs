using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string[] arr = s.Split(" ");
        List<string> list = new List<string>();
        for(int i = 0; i < arr.Length; i++)
        {
            if (string.IsNullOrEmpty(arr[i]))
            {
                continue;
            }
            for(int j = 0; j < arr[i].Length; j++)
            {
                if(j % 2 == 0 && arr[i][j] >= 65 && arr[i][j] <= 90) // 짝수일 경우 대문자
                {
                    list.Add(arr[i][j].ToString());
                }
                else if(j % 2 == 0 && arr[i][j] >= 97 && arr[i][j] <= 122) // 짝수일 경우 소문자
                {
                    list.Add(((char)(arr[i][j] - 32)).ToString());
                }
                else if(j % 2 == 1 && arr[i][j] >= 65 && arr[i][j] <= 90) // 홀수일 경우 소문자
                {
                    list.Add(((char)(arr[i][j] + 32)).ToString());
                }
                else if(j % 2 == 1 && arr[i][j] >= 97 && arr[i][j] <= 122) // 홀수일 경우 소문자
                {
                    list.Add(arr[i][j].ToString());
                }
                else // 공백일 경우
                {
                    list.Add(" ");
                }
            }
        }
        int count = 0;
        string answer = "";
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                answer += " ";
            }
            else
            {
                answer += list[count++];
            }
        }
       
        return answer;
    }
}