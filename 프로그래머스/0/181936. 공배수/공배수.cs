using System;

public class Solution {
    public int solution(int number, int n, int m) {
        int answer = 0;
       
        var a = number % n;
        var b = number % m;
       
        if(a == 0 && b == 0){
            answer = 1;
        } else{
            answer = 0;
        }
       
        return answer;
    }
}