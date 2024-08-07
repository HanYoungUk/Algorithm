using System;

public class Solution {
    public bool solution(string s) {
        int count = 0;
        bool answer = false;

        for(int i = 0; i < s.Length; i++)
        {
            if (count == 0 && s[i] == ')')
            {
                count = 1;
                break;
            }

            if (s[s.Length - 1] == '(')
            {
                count = 1;
                break;
            }

            if (s[i] == '(')
            {
                count += 1;
            }
            else
            {
                count -= 1;
            }
        }

        if(count == 0)
        {
            answer = true;
        }
        return answer;
    }
}