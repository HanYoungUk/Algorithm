using System;

public class Solution {
    public int[] solution(int n) {
        int count = 0;
            if (n % 2 == 0)
            {
                int[] answer = new int[n / 2];
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        answer[count++] = i;
                    }
                }
                 return answer;
            }
            else
            {
                int[] answer = new int[n / 2 + 1];
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        answer[count++] = i;
                    }
                }
                 return answer;
            }
       
    }
}