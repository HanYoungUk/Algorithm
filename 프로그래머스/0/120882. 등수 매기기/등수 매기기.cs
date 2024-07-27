using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[,] score) {
        List<int> list = new List<int>();
        int[] answer = new int[score.GetLength(0)];

        for(int i = 0; i < score.GetLength(0); i++)
        {
            int sum = 0;
            for(int j = 0; j < score.GetLength(1); j++)
            {
                sum += score[i, j];
            }
            list.Add(sum);
        }

        for(int i = 0; i < list.Count; i++)
        {
            int count = 1;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[i] < list[j])
                {
                    count++;
                }
            }
            answer[i] = count;
        }
        return answer;
    }
}