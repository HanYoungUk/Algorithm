using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
       
        string[] arr = new string[my_string.Length];
       
        for(int i = 0; i < my_string.Length; i++)
        {
            arr[i] = $"{my_string[i]}";
        }

        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < n; j++)
            {
                answer += arr[i];
            }
        }
       
       
       
        return answer;
    }
}