using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 1;
        int num = 0;
        for(int i = 0; i < box.Length; i++){
          num = box[i] / n;
          answer *= num;
        }
       
        return answer;
    }
}