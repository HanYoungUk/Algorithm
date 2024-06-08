using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
       
        List<string> list = new List<string>();
       
        for (int i = 0; i < strArr.Length; i++)
         {
             if (strArr[i].Contains("ad"))
             {

             }
             else
             {
                 list.Add(strArr[i]);
             }
         }
         string[] answer = new string[list.Count];

         for(int i = 0; i < answer.Length; i++)
         {
             answer[i] = list[i];
         }
       
       
        return answer;
    }
}