using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
       
        var x = $"{a}{b}";
        var y = $"{b}{a}";
           
        if(Int32.Parse(x) >= Int32.Parse(y)){
            answer = Int32.Parse(x);
        } else{
            answer= Int32.Parse(y);
        }
        return answer;
    }
}