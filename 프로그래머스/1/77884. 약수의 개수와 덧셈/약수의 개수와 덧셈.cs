using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
       
        HashSet<int> num = new HashSet<int>();
    for(int i = left; i <= right; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            if(i % j == 0)
            {
                num.Add(j);
            }
        }
   
        if(num.Count % 2 == 0)
        {
            answer += i;
        }
        else
        {
            answer -= i;
        }

        num.Clear();
    }
        return answer;
    }
}