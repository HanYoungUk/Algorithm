using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
       
        for(int i = 1; i <= 1_000_000; i++){
            if(n == i * i){
                answer = 1;
                break;
            } else{
                answer = 2;
            }
        }
       
       
        return answer;
    }
}