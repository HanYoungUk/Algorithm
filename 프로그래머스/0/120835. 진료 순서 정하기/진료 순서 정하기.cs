using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
       
          for (int i = 0; i < emergency.Length; i++)
          {
              int count = 1;
              for(int j = 0; j < emergency.Length; j++)
              {
                  if (emergency[i] < emergency[j])
                  {
                      count++;
                  }
              }
              answer[i] = count;
          }
       
        return answer;
    }
}
