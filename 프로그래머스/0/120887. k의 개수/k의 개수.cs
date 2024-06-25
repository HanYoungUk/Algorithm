using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
       
        for(int a = i; a <= j; a++)
        {
           string str = a.ToString();
            string x = k.ToString();
            if (str.Contains(x))
            {
                for(int w = 0; w < str.Length; w++)
                {
                    if (str[w] - '0' == k)
                    {
                        answer++;
                    }
                }

            }
        }
        return answer;
    }
}
