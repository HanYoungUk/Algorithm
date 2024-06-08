using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        var str = "";
       
       for (int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'A')
            {
                str += "B";
            }
            else
            {
                str += "A";
            }
        }

        if (str.Contains(pat))
        {
            answer = 1;
        }
        else
        {
            answer = 0;
        }
       
        return answer;
    }
}