using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        List<string> list = new List<string>();
        int count = 0;
        for(int i = 0; i < finished.Length; i++){
            if(finished[i] == false){
                list.Add(todo_list[i]);
            }
        }
       
        string[] answer = new string[list.Count];
       
        for(int i = 0; i < list.Count; i++){
            answer[i] = list[i];
        }
        return answer;
    }
}