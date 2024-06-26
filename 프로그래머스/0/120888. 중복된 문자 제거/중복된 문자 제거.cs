using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
       
       HashSet<String> list = new HashSet<string>();
        for(int i = 0; i < my_string.Length; i++)
        {
            list.Add($"{my_string[i]}");
        }

        foreach(string i in list)
        {
            answer += i;
        }
       
        return answer;
    }
}