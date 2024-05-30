using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        int count = 0;
        for(int i = 1; i <= 100; i++){
           
            answer *= i;
           
            if(answer > n){
                count = i;
                break;
            }
           
        }
       
       
        return count - 1;
    }
}