using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n, n];
        int count = 0;
        for(int i = 0; i < answer.GetLength(0); i++)
        {
            answer[i, count++] = 1;
        }
        return answer;
    }
}