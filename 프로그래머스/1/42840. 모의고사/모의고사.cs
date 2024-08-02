using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] answers) {
       int[] student1 = { 1, 2, 3, 4, 5 };
        int[] student2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] student3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        int index1 = 0; // student 배열인덱스 가져오기용
        int index2 = 0;
        int index3 = 0;
        int score1 = 0;
        int score2 = 0;
        int score3 = 0;

        for(int i = 0; i < answers.Length; i++)
        {
            if (student1[index1] == answers[i])
            {
                score1++;
            }
            if (student2[index2] == answers[i])
            {
                score2++;
            }
            if (student3[index3] == answers[i])
            {
                score3++;
            }
            index1++;
            index2++;
            index3++;
            if(index1 > student1.Length - 1)
            {
                index1 = 0;
            }
            if(index2 > student2.Length - 1)
            {
                index2 = 0;
            }
            if(index3 > student3.Length - 1)
            {
                index3 = 0;
            }
        }

        Dictionary<int, int> dic = new Dictionary<int, int>();
        dic.Add(1, score1);
        dic.Add(2, score2);
        dic.Add(3, score3);

        int max = dic.Max(x => x.Value);
       
        List<int> answer = dic.Where(x => x.Value == max).Select(x => x.Key).ToList();
        return answer;
    }
}