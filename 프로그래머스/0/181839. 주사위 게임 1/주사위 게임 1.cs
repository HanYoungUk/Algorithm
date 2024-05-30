using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
       
       
        if(a % 2 == 1 && b % 2 == 1){
         
        int x = a * a;
        int y = b * b;
        answer = x + y;
        } else if(a % 2 == 0 && b % 2 == 0){
            answer = Math.Abs(a - b);
        } else{
            answer = 2 * (a + b);
        }
       
       
       
        return answer;
    }
}