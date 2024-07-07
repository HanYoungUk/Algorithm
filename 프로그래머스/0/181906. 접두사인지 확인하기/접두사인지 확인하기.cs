using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 0;
        int count = 0;

       if(my_string.Length < is_prefix.Length)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i < is_prefix.Length; i++)
            {
                if (is_prefix[i] == my_string[i])
                {
                    count++;
                }
            }

            if (count == is_prefix.Length)
            {
                answer = 1;
            }
        }

        return answer;
    }
}
