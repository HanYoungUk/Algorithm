using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int count = 0;
        int answer = 0;
        Array.Sort(d);
       
       
         foreach(int i in d)
         {
             count += i;
             if(count > budget)
             {
                 break;
             }
             answer++;
         }
       
        return answer;
    }
}