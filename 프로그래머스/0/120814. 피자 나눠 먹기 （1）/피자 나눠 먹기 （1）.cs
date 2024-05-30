using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
       
        var x = n % 7;
        var y = n / 7;

        if(x == 0)
        {
            answer = y;
        }
        else
        {
            answer = y + 1;
        }
       
       
        return answer;
    }
}