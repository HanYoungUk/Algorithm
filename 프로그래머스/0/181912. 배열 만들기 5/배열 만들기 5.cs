using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string[] intStrs, int k, int s, int l) {
        List<int> list = new List<int>();
       
        for (int i = 0; i < intStrs.Length; i++)
        {
            string str = "";
            for (int j = s; j < s + l; j++)
            {
                str += intStrs[i][j];
            }
            if (k < Int32.Parse(str))
            {
                list.Add(Int32.Parse(str));
            }
        }
        return list;
    }
}