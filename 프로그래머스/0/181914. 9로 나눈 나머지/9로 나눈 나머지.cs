using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        int x = 0;
        for(int i = 0; i < number.Length; i++)
        {
            x += number[i] - '0';
        }
        answer = x % 9;
       
        return answer;
    }
}
