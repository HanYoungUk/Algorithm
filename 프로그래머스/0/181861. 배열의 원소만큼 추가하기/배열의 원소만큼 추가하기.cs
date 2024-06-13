using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
       
        List<int> list = new List<int>();
        for(int i = 0; i < arr.Length; i++){
            for(int j = 1; j <= arr[i]; j++){
                list.Add(arr[i]);
            }
        }
        int[] answer = new int[list.Count];
       
        for(int i = 0; i < answer.Length; i++){
           answer[i] = list[i];
        }
       
        return answer;
    }
}