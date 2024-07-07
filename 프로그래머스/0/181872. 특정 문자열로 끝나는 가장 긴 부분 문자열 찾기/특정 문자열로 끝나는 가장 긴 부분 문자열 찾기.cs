using System;

public class Solution {
    public string solution(string myString, string pat) {
       
        int i = myString.LastIndexOf(pat);
        string answer = myString.Substring(0, i + pat.Length);
       
       
        return answer;
    }
}
