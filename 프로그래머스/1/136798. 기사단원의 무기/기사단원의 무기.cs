using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
         List<int> list = new List<int>();
         int answer = 0;
       
         for(int i = 1; i <= number; i++)
        {
            int count = 0;
            for(int j = 1; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0) // 약수 구하기
                {
                    count++;
                    if (j * j != i) // 다른 수 일 경우
                    {
                        count++;
                    }
                }
            }
            if(count > limit) // limit보다 크면
            {
                count = power;
            }
            answer += count;
        }
       
        return answer;
    }
}