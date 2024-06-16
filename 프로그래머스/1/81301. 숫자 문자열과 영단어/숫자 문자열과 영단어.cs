using System;

public class Solution {
    public long solution(string s) {
        long answer = 0;
       
        string[] arr = { "zero" , "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for(int i = 0; i < arr.Length; i++)
        {
            s = s.Replace(arr[i],$"{i}");
        }
       
        answer = Int64.Parse(s);
        return answer;
    }
}