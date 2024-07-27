using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        if (arr.GetLength(0) > arr.GetLength(1))
        {
            int x = arr.GetLength(0);
            int[,] answer = new int[x, x];

            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }
            return answer;
        }
        else if(arr.GetLength(0) < arr.GetLength(1))
        {
            int x = arr.GetLength(1);
            int[,] answer = new int[x, x];

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < x; j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }
            return answer;
        }
        else
        {
            int x = arr.GetLength(0);
            int[,] answer = new int[x, x];

            for(int i = 0; i< x; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    answer[i, j] = arr[i, j];
                }
            }
            return answer;
        }
       
    }
}