using System;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[arr.Length];
        int count = 0;
        foreach(int i in arr){
            if(i % 2 == 0 && i >= 50){
               answer[count++] = i / 2;
            } else if(i < 50 && i % 2 == 1){
                answer[count++] = i * 2;
            } else{
                answer[count++] = i;
            }
        }
        return answer;
    }
}