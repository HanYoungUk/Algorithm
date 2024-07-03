using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string my_string, string is_suffix) {

       
        List<string> list = new List<string>();
        int count = 1;
        string str = "";
       
        for (int i = my_string.Length - 1; i >= 0; i--)
         {
             str += my_string[i];

             string newStr = new string(str.Reverse().ToArray());
             if (str.Length == count++)
             {
                 list.Add(newStr);
             }
         }

        int answer = list.IndexOf(is_suffix) == -1 ? 0 : 1;
       
        return answer;
    }
}