using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        
        string abc = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
        List<char> list = abc.ToCharArray().ToList();
        string answer = "";

        for (int i = 0; i < skip.Length; i++)
        {
            list.Remove(skip[i]);
            list.Remove(skip[i]);
            list.Remove(skip[i]);
            list.Remove(skip[i]);
        }

        for (int i = 0; i < s.Length; i++)
        {
            answer += list[list.IndexOf(s[i]) + index];
        }
        
        return answer;
    }
}