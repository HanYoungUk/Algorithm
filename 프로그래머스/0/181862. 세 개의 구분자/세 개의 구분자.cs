using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string myStr) {
        string str = "";
        List<string> list = new List<string>();
        for(int i = 0; i < myStr.Length; i++)
        {
            if (myStr[i] == 'a' || myStr[i] == 'b' || myStr[i] == 'c')
            {
                if(str.Equals(""))
                {
                    continue;
                }
                else
                {
                    list.Add(str);
                    str = "";
                }
                continue;
            }
            else if (i == myStr.Length - 1)
            {
                str += myStr[i];
                list.Add(str);
            }
            else
            {
                str += myStr[i];
            }
        }
        if (list.Count == 0)
        {
            list.Add("EMPTY");
        }
        return list;
    }
}