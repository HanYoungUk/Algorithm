using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int mul = 1;
        if(num_list.Length >= 11){
            foreach(int i in num_list){
                answer += i;
            }
        } else {
            for(int i = 0; i < num_list.Length; i++){
                mul *= num_list[i];
            }
            answer = mul;
        }
       
       
        return answer;
    }
}