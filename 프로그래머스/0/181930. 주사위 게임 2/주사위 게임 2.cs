using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        int x = (a * a) + (b * b) + (c * c);
        int y = a + b + c;
       
        if(a != b && b != c && c != a){
            answer = y;
        } else if(a == b && b == c && c == a){
            answer = (a + b + c) * x * ((a * a * a) + (b * b * b) + (c * c * c));
        } else{
            answer = y * x;
        }
       
        return answer;
    }
}