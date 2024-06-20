using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
         string a = "";
       
        for(int i = 0; i < t.Length; i++)
        {
            a += t[i];
            if (a.Length == p.Length)
            {

                if(Int64.Parse(a) <= Int64.Parse(p)){
                    answer++;

                }
                a = "";
                i = i - (p.Length -1);
            }
        }
       
        return answer;
    }
}