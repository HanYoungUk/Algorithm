using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> list = new List<int>();
        int[] answer = new int[score.Length];
        for(int i = 0; i < score.Length; i++)
        {
            list.Add(score[i]); // list에 score[i]를 넣어준다.

            if (list.Count > k) // list의 개수가 k보다 크면
            {
                list.Remove(list.Min()); // list의 최소값을 제거한다.
            }
            list.Sort(); // 오름차순 정렬

            answer[i] = list[0]; // answer[i]에 list[0]를 넣어준다.
        }
        return answer;
    }
}