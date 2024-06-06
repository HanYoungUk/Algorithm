using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        int count = 0;
        for(int i = num_list.Length - 1; i >= 0; i--){
            answer[count++] = num_list[i];
        }
        
        return answer;
    }
}