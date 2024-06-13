using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string[] names) {
       
        List<string> answer = new List<string>();
       
        for(int i = 0; i < names.Length; i = i + 5){
            answer.Add(names[i]);
        }
        return answer;
    }
}