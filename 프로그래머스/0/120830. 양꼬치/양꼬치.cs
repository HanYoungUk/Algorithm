using System;

public class Solution {
    public int solution(int n, int k) {
       
       
        if(n >= 10){
            k = k - (n / 10);
        }
       
        int answer = (n * 12_000) + (k * 2_000);
       
        return answer;
    }
}