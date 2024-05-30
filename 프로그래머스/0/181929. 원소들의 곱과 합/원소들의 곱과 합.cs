using System;


public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
       
        int x = 1;
        int sum = 0;
        for(int i = 0; i < num_list.Length; i++){
            x *= num_list[i];
        }
       
        for(int i = 0; i < num_list.Length; i++){
    sum += num_list[i];
}
        if(x < Math.Pow(sum,2)){
            answer = 1;
        } else {
            answer = 0;
        }
       
        return answer;
    }
}