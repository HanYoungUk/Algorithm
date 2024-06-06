using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
       
        if(n % 2 == 1){ // 홀수 일경우
            for(int i = 1; i <= n; i = i + 2){
                answer += i;
            }
        } else { // 짝수 일경우
            for(int i = 2; i <= n; i = i + 2){
                answer += i * i;
            }
        }
        return answer;
    }
}