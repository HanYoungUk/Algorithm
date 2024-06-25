using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        char[] chars = my_string.ToCharArray();
       
        foreach(int i in indices)
        {
            Array.Clear(chars, i, 1);
        }

        foreach(char c in chars)
        {
            if(c >= 97 && c <= 122)
             {
                 answer += c;
             }
        }
       
        return answer;
    }
}