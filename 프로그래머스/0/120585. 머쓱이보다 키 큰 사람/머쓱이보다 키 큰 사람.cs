using System;

public class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
       
        foreach(int a in array){
            if(a > height){
                answer++;
            }
        }
        return answer;
    }
}
