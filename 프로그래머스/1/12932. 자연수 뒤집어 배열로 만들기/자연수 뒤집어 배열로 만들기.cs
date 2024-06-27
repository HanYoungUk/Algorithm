using System.Collections.Generic;

public class Solution {
    public List<int> solution(long n) {
       
        List<int> answer = new List<int>();

        string s = n.ToString();

        for(int i = 0; i < s.Length; i++)
        {
            answer.Add((s[i]) - '0');
        }

        answer.Reverse();
       
        return answer;
    }
}