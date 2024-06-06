using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        int[] answer = new int[num2 - num1 + 1];
        List<int> list = new List<int>();
        
        for(int i = num1; i <= num2; i++){
            list.Add(numbers[i]);
        }
        
        for(int i = 0; i < list.Count; i++){
           answer[i] = list[i];
        }
        
        return answer;
    }
}