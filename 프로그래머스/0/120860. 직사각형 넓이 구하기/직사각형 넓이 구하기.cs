using System;

public class Solution {
    public int solution(int[,] dots) {
       
      int max1 = dots[0, 0]; // x좌표
        int max2 = dots[0, 1]; // y좌표
        int min1 = dots[0, 0]; // x좌표
        int min2 = dots[0, 1]; // y좌표

        for(int i = 0; i < dots.GetLength(0); i++)
        {
            if(max1 < dots[i, 0])
            {
                max1 = dots[i, 0];
            }
            if(max2 < dots[i, 1])
            {
                max2 = dots[i, 1];
            }
            if(min1 > dots[i, 0])
            {
                min1 = dots[i, 0];
            }
            if(min2 > dots[i, 1])
            {
                min2 = dots[i, 1];
            }
        }

        int x = max1 - min1;
        int y = max2 - min2;

        int answer = x * y;

        return answer;
    }
}