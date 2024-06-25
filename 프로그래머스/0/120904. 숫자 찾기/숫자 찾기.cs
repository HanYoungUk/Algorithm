using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string snum = num.ToString();
        for(int i = 0; i < snum.Length; i++)
        {
            if ((snum[i] - '0') == k)
            {
                answer = i + 1;
                break;
            }
        }
        if(answer == 0)
        {
            answer = -1;
        }
        return answer;
    }
}