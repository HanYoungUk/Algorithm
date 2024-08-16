using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n - lost.Length;
        Array.Sort(lost);
        Array.Sort(reserve);

        for(int i = 0; i < lost.Length; i++)
        {
            int distinct = Array.IndexOf(reserve, lost[i]);
            if (distinct != -1)
            {
                answer += 1;
                lost[i] = -1;
                reserve[distinct] = -1;
                continue;
            }
        }

        for (int i = 0; i < lost.Length; i++)
        {

            for (int j = 0; j < reserve.Length; j++)
            {
                if (lost[i] - 1 == reserve[j]) // 1 더 낮을 때
                {
                    answer += 1;
                    reserve[j] = -1;
                    break;
                }
                if (lost[i] + 1 == reserve[j]) // 1 더 높을 때
                {

                    answer += 1;
                    reserve[j] = -1;
                    break;
                }
            }
        }
        return answer;
    }
}