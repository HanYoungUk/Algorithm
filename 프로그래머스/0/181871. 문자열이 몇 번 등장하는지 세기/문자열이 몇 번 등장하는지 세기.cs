using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        int count = 1;
        int num = 0;
        for(int i = 0; i <= myString.Length - pat.Length; i++)
        {
            if (myString[i] == pat[0])
            {
                int x = i;

                for(int j = 1; j < pat.Length; j++)
                {

                    if (myString[++x] == pat[j])
                    {
                        count++;
                    }
                }
                if(count == pat.Length)
                {
                    answer++;
                    count = 1;
                }
                count = 1;
            }
        }
        return answer;
    }
}