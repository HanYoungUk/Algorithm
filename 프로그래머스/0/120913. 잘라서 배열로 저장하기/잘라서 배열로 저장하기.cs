using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string my_str, int n) {
       
        List<string> list = new List<string>();

        string str = "";
        int count = 0;
        for (int i = 0; i < my_str.Length; i++)
        {

            if (count == n)
            {
                list.Add(str);
                str = "";
                count = 0;
            }
            count++;
            str += my_str[i];
            if(my_str.Length -1 == i)
            {
                list.Add(str);
            }
        }
        return list;
    }
}
