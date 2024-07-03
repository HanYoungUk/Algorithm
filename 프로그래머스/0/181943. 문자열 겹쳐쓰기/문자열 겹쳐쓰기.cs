using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        int count = 0;
        int x = s;
        for(int i = 0; i < my_string.Length; i++)
        {
            if(i == x)
            {

                answer += overwrite_string[count++];
                if(count == overwrite_string.Length)
                {
                    continue;
                }
                x++;
            }
            else
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}
