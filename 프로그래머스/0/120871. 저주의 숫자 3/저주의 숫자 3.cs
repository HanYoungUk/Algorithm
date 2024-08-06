using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        int num = 1;
        string str = "";
        for(int i = 1; i <= n; i++)
        {
            while (true)
            {
                str = answer.ToString();
                if (answer % 3 == 0 || str.Contains("3"))
                {
                    answer++;

                    continue;
                }
                else
                {
                    if (i == n)
                    {
                        break;
                    }
                    answer++;
                    break;
                }
            }
        }
        return answer;
    }
}