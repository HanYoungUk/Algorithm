using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string[] str_list) {
        List<string> list = new List<string>();
        for(int i = 0; i < str_list.Length; i++)
        {
            if (str_list[i] == "l")
            { int index = i;
                for (int j = 0; j < i; j++)
                {
                    list.Add(str_list[j]);
                }
                break;
            }
            else if (str_list[i] == "r")
            {
                int index = i;
                for(int j = i + 1; j < str_list.Length; j++)
                {
                    list.Add(str_list[j]);
                }
                break;
            }
        }
        return list;
    }
}