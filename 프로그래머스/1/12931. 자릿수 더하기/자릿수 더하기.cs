using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string s = n.ToString();
       
        for(int i = 0; i <s.Length; i++){
          answer += s[i] - '0';
        }
        return answer;
    }
}