using System;

public class Solution {
    public long solution(int[] a, int[] b) {
        long answer = 0;
       
         for(int i = 0; i < a.Length; i++)
         {
             answer += a[i] * b[i];
         }
       
        return answer;
    }
}